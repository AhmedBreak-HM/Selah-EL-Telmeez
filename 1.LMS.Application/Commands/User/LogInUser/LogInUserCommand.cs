using MediatR;

namespace _1.LMS.Application.Commands.User.LogInUser
{
    public class LogInUserCommand : IRequest<LogInUserForReturnDto>
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}