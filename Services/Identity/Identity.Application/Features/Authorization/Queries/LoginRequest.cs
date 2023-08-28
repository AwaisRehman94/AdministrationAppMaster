
using FluentValidation;
using MediatR;

using Identity.Application.Common.Utilities;
using Identity.Domain.Entities;
using Identity.Application.Common.Interfaces;

using Common.Domain.Models;
using Common.Domain.Common.Models;
using Common.Domain.Entities.LogEntities;

using Common.Application.Common.Interfaces;
using Common.Application.Common.Interfaces.Persistence.Logs;
using Common.Domain.Enums;
using Tameenk.Resources.WebResources;
using Common.Domain.Utilities;

namespace Identity.Application.Features.Authorization.Queries
{
    public class LoginRequest : BaseViewModel, IRequest<Result<LoginResponse>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LoginRequestHandler : IRequestHandler<LoginRequest, Result<LoginResponse>>
    {
        private readonly ILoginRequestsLogService _loginRequestsLogService;
        private readonly ITokenService _tokenService;
        private readonly IAuthorizationService _authorizationService;
        private readonly IAutoLeasingUserService _autoLeasingUserService;
        private readonly IAutoleasingVerifyUserService _autoleasingVerifyUserService;
        private readonly IValidator<LoginRequest> _validator;

        public LoginRequestHandler(ILoginRequestsLogService loginRequestsLogService, IValidator<LoginRequest> validator, IAutoleasingVerifyUserService autoleasingVerifyUserService, IAuthorizationService authorizationService, IAutoLeasingUserService autoLeasingUserService,  ITokenService tokenService)
        {
            _loginRequestsLogService = loginRequestsLogService;
            _authorizationService = authorizationService;
            _autoLeasingUserService = autoLeasingUserService;
            _autoleasingVerifyUserService = autoleasingVerifyUserService;
            _validator = validator;
            _tokenService = tokenService;
        }

        public async Task<Result<LoginResponse>> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var log = new LoginRequestsLog() { };
            var startTime = DateTime.UtcNow;
            log.Email = request.Email;
            log.Channel = request.Channel.ToString();
            log.ServerIp = Utilities.GetInternalServerIP();
            log.UserAgent = Utilities.GetUserAgent();
            log.UserIp = Utilities.GetUserIPAddress();

            Result<LoginResponse> output = new Result<LoginResponse>();
            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                output.ErrorDescription = validationResult.ToString(",");
                output.ErrorCode = (int)ErrorCodes.EmptyInputParamter;
                log.ErrorCode = output.ErrorCode;
                log.ErrorDescription = output.ErrorDescription;
                log.ServiceResponseTimeInSeconds = DateTime.UtcNow.Subtract(startTime).TotalSeconds;
                await _loginRequestsLogService.LogAsync(log);
                return output;
            }

            var authrizedUser = await _authorizationService.GetUserByEmailAsync(request.Email);

            if (authrizedUser == null)
            {
                output.ErrorDescription = WebResources.ResourceManager.GetString("login_incorrect_password_message", System.Globalization.CultureInfo.GetCultureInfo(request.Language))!;
                output.ErrorCode = (int)ErrorCodes.EmptyInputParamter;
                
                log.ErrorCode = output.ErrorCode;
                log.ErrorDescription = "autoleasingUser is null for email " + request.Email;
                log.ServiceResponseTimeInSeconds = DateTime.UtcNow.Subtract(startTime).TotalSeconds;
                await _loginRequestsLogService.LogAsync(log);
                
                return output;
            }

            var autoLeasingUser = await _autoLeasingUserService.GetUserByEmailAsync(authrizedUser.Email!);

            if (autoLeasingUser == null)
            {
                output.ErrorDescription = WebResources.ResourceManager.GetString("login_incorrect_password_message", System.Globalization.CultureInfo.GetCultureInfo(request.Language))!;
                output.ErrorCode = (int)ErrorCodes.EmptyInputParamter;

                log.ErrorCode = output.ErrorCode;
                log.ErrorDescription = "autoleasingUser is null for email " + request.Email;
                log.ServiceResponseTimeInSeconds = DateTime.UtcNow.Subtract(startTime).TotalSeconds;
                await _loginRequestsLogService.LogAsync(log);

                return output;
            }
            if (autoLeasingUser.LockoutEndDateUtc > DateTime.UtcNow)
            {
                output.ErrorDescription = WebResources.ResourceManager.GetString("AccountLocked", System.Globalization.CultureInfo.GetCultureInfo(request.Language))!;
                output.ErrorCode = (int)ErrorCodes.EmptyInputParamter;

                log.ErrorCode = output.ErrorCode;
                log.ErrorDescription = "Account is Locked";
                log.ServiceResponseTimeInSeconds = DateTime.UtcNow.Subtract(startTime).TotalSeconds;
                await _loginRequestsLogService.LogAsync(log);
                return output;
            }
            if (autoLeasingUser.IsDeleted.HasValue && autoLeasingUser.IsDeleted.Value)
            {
                output.ErrorDescription = WebResources.ResourceManager.GetString("login_incorrect_password_message", System.Globalization.CultureInfo.GetCultureInfo(request.Language))!;
                output.ErrorCode = (int)ErrorCodes.EmptyInputParamter;

                log.ErrorCode = output.ErrorCode;
                log.ErrorDescription = "Account is deleted";
                log.ServiceResponseTimeInSeconds = DateTime.UtcNow.Subtract(startTime).TotalSeconds;
                await _loginRequestsLogService.LogAsync(log);
                return output;
            }
            if (!SecurityUtilities.VerifyHashedData(autoLeasingUser.PasswordHash, request.Password))
            {
                output.ErrorDescription = WebResources.ResourceManager.GetString("login_incorrect_password_message", System.Globalization.CultureInfo.GetCultureInfo(request.Language))!;
                output.ErrorCode = (int)ErrorCodes.NotAuthorized;

                log.ErrorCode = output.ErrorCode;
                log.ErrorDescription = "incorrect username and password asp net user " + request.Password.Trim() +
                                           " and hashed password is " + autoLeasingUser.PasswordHash;
                log.ServiceResponseTimeInSeconds = DateTime.UtcNow.Subtract(startTime).TotalSeconds;
                await _loginRequestsLogService.LogAsync(log);
                return output;
            }

            var OTP = GenerateRendomCode();
            var verifyData = new AutoleasingVerifyUser();
            verifyData.CreatedDate = DateTime.UtcNow;
            verifyData.UserId = authrizedUser.Id;
            verifyData.VerificationCode = OTP.ToString();
            verifyData.ExpiryDate = DateTime.Now.AddMinutes(15);
            verifyData.MethodName = "PortalLogin";
            await _autoleasingVerifyUserService.InsertAsync(verifyData);

            //TODO send SMS by configured Provider
            var token = _tokenService.GenerateToken(authrizedUser.Id);
            output.ErrorDescription = WebResources.ResourceManager.GetString("Success", System.Globalization.CultureInfo.GetCultureInfo(request.Language))!;
            output.ErrorCode = (int)ErrorCodes.Success;
            log.ErrorCode = output.ErrorCode;
            log.ErrorDescription = "Success";
            log.ServiceResponseTimeInSeconds = DateTime.UtcNow.Subtract(startTime).TotalSeconds;
            await _loginRequestsLogService.LogAsync(log);
            output.Data = new LoginResponse() { VerificationCode = verifyData.VerificationCode, Token = token };
            return output;
        }

        private int GenerateRendomCode()
        {
            Random rnd = new Random();
            int code = rnd.Next(100000, 999999);
            return code;
        }
    }
}