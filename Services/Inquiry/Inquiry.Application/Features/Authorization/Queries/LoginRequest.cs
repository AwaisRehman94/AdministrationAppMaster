
//using FluentValidation;
//using MediatR;

//using GlobalCommon.Application.Common.Models;

//using Inquiry.Application.Common.Models;
//using Inquiry.Application.Common.Utilities;
//using Identity.Application.Common.Interfaces;
//using Identity.Domain.Entities;

//namespace Inquiry.Application.Features.Authorization.Queries
//{
//    public class LoginRequest : BaseViewModel, IRequest<Result<LoginResponse>>
//    {
//        public string Email { get; set; }
//        public string Password { get; set; }
//    }

//    public class LoginRequestHandler : IRequestHandler<LoginRequest, Result<LoginResponse>>
//    {
//        private readonly IAuthorizationService _authorizationService;
//        private readonly IAutoLeasingUserService _autoLeasingUserService;
//        private readonly IAutoleasingVerifyUserService _autoleasingVerifyUserService;
//        private readonly IValidator<LoginRequest> _validator;

//        public LoginRequestHandler(IValidator<LoginRequest> validator, IAutoleasingVerifyUserService autoleasingVerifyUserService, IAuthorizationService authorizationService, IAutoLeasingUserService autoLeasingUserService)
//        {
//            _authorizationService = authorizationService;
//            _autoLeasingUserService = autoLeasingUserService;
//            _autoleasingVerifyUserService = autoleasingVerifyUserService;
//            _validator = validator;
//        }

//        public async Task<Result<LoginResponse>> Handle(LoginRequest request, CancellationToken cancellationToken)
//        {
//            Result<LoginResponse> result = new Result<LoginResponse>();
//            var validationResult = await _validator.ValidateAsync(request);
//            if(!validationResult.IsValid)
//            {
//                result.ErrorDescription = validationResult.ToString(",");
//                result.ErrorCode = 2;
//                return result;
//            }

            
//            var authrizedUser = await _authorizationService.GetUserByEmailAsync(request.Email);

//            if (authrizedUser == null)
//            {
//                result.ErrorDescription = "user not found";
//                result.ErrorCode = 2;
//                return result;
//            }

//            var autoLeasingUser = await _autoLeasingUserService.GetUserByEmailAsync(authrizedUser.Email);

//            if (autoLeasingUser == null)
//            {
//                result.ErrorDescription = "user not found";
//                result.ErrorCode = 3;
//                return result;
//            }
//            if(autoLeasingUser.LockoutEndDateUtc > DateTime.UtcNow)
//            {
//                result.ErrorDescription = "Account locked";
//                result.ErrorCode = 4;
//                return result;
//            }
//            if (autoLeasingUser.IsDeleted.HasValue && autoLeasingUser.IsDeleted.Value)
//            {
//                result.ErrorDescription = "Account deleted";
//                result.ErrorCode = 5;
//                return result;
//            }
//            if (!SecurityUtilities.VerifyHashedData(autoLeasingUser.PasswordHash, request.Password))
//            {
//                result.ErrorDescription = "incorrect username and password";
//                result.ErrorCode = 6;
//                return result;
//            }

//            var verifyData = new AutoleasingVerifyUser();
//            verifyData.CreatedDate = DateTime.Now;
//            verifyData.UserId = authrizedUser.Id;
//            verifyData.VerificationCode = GenerateRendomCode().ToString();
//            verifyData.ExpiryDate = DateTime.Now.AddMinutes(15);
//            verifyData.MethodName = "AutoLeasingServiceCoreLogin";
//            var vResult = _autoleasingVerifyUserService.Insert(verifyData);


//            //TODO send SMS by configured Provider

//            result.ErrorDescription = vResult.Result > 0 ?"success" : "Failure";
//            result.ErrorCode = vResult.Result > 0 ? 1 : 7;
//            result.Data = vResult.Result > 0 ? new LoginResponse() { VerificationCode = verifyData.VerificationCode } : null;
//            return result;
//        }

//        private int GenerateRendomCode()
//        {
//            Random rnd = new Random();
//            int code = rnd.Next(100000, 999999);
//            return code;
//        }
//    }
//}