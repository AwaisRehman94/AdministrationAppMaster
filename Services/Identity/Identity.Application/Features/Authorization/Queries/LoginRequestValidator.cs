
using FluentValidation;
using Tameenk.Resources.WebResources;

namespace Identity.Application.Features.Authorization.Queries
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            //RuleFor(v => v.Email).NotEmpty().WithMessage("Email Address is required to make login");
            RuleFor(v => v.Email).NotEmpty().WithMessage(x => x.Language == "ar" ?
            WebResources.ResourceManager.GetString("EmptyEmail", System.Globalization.CultureInfo.GetCultureInfo("ar")) :
            WebResources.ResourceManager.GetString("EmptyEmail", System.Globalization.CultureInfo.GetCultureInfo("en")));

            // RuleFor(r => r.Password).NotEmpty().WithMessage("Password is required to make login");
            RuleFor(r => r.Password).NotEmpty().WithMessage(x => x.Language == "ar" ?
            WebResources.ResourceManager.GetString("login_incorrect_password_message", System.Globalization.CultureInfo.GetCultureInfo("ar")) :
            WebResources.ResourceManager.GetString("login_incorrect_password_message", System.Globalization.CultureInfo.GetCultureInfo("en")));
        }
    }
}