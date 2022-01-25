using _0.LMS.Domain.AggregateModels.SubscriptionModels;
using _1.LMS.Application.Commands.User.LogInUser;
using _1.LMS.Application.Queries.User.GetUserByName;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

namespace _1.LMS.Application.Contracts
{
    public interface IUserRepository
    {
        // In DDD  When You Post Shoud Interact With DomainModel Not Dto
        // UserApplication userApplication
        Task<IdentityResult> SignUp(UserApplication userApplication, string password);

        Task<LogInUserForReturnDto> LogIn(LogInUserCommand logInUserCommand, CancellationToken cancellationToken);

        Task<UserForReturnDto> GetUserByName(string name);
    }
}