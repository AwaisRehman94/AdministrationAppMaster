using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquiry.Application.Features.Authorization.Queries
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(v => v.Email).NotEmpty().WithMessage("Email Address is required to make login");
            RuleFor(r => r.Password).NotEmpty().WithMessage("Password is required to make login");
        }
    }
}