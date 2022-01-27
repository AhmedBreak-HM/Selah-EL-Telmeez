using MediatR;
using Microsoft.AspNetCore.Identity;
using System;

namespace _1.LMS.Application.Commands.User.SignUpUser
{
    public class SignUpUserCommand : IRequest<IdentityResult>
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public int StudingYear { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public DateTime YearOfBirth { get; set; }
        public int City { get; set; }
        private DateTime subscirbedEndDate;

        public DateTime SubscirbedEndDate
        {
            get { return subscirbedEndDate; }
            set { subscirbedEndDate = DateTime.Now.AddDays(15); }
        }
    }
}