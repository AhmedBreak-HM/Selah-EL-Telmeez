using FluentValidation;

namespace _1.LMS.Application.Commands.User.SignUpUser
{
    public class SignUpUserCommandValidator : AbstractValidator<SignUpUserCommand>
    {
        public SignUpUserCommandValidator()
        {
            RuleFor(p => p.Email).NotEmpty().NotNull().EmailAddress();
            RuleFor(p => p.UserName).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(p => p.StudingYear).NotEmpty().NotNull();
            RuleFor(p => p.Password).NotEmpty().NotNull().MinimumLength(7);
        }
    }
}