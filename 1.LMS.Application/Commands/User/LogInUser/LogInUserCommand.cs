using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.LMS.Application.Commands.User.LogInUser
{
    public class LogInUserCommand : IRequest<LogInUserForReturnDto>
    {
        public string Email { get; set; }

        public string Password { get; set; }


    }
}
