using _1.LMS.Application.Commands.User.LogInUser;
using _1.LMS.Application.Commands.User.SignUpUser;
using _1.LMS.Application.Queries.User.GetUserByName;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

namespace _1.LMS.Application.Contracts
{
    public interface IUserRepository
    {
        Task<IdentityResult> SignUp(SignUpUserCommand signUpUserCommand, CancellationToken cancellationToken);
        Task<LogInUserForReturnDto> LogIn(LogInUserCommand logInUserCommand, CancellationToken cancellationToken);
        Task<UserForReturnDto> GetUserByName(string name, CancellationToken cancellationToken);
    }
}
