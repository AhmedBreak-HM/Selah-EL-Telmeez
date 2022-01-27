using FluentValidation;

namespace _1.LMS.Application.Commands.User.LogInUser
{
    public class LogInUserCommandValidator : AbstractValidator<LogInUserCommand>
    {
        public LogInUserCommandValidator()
        {
            RuleFor(p => p.Email).NotEmpty().NotNull().EmailAddress();
            RuleFor(p => p.Password).NotEmpty().NotNull().MinimumLength(7);
        }
    }
}