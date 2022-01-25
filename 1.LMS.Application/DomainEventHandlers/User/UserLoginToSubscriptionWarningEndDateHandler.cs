using _0.LMS.Domain.Events;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace _1.LMS.Application.DomainEventHandlers
{
    public class UserLoginToSubscriptionWarningEndDateHandler : INotificationHandler<UserLoginToSubscriptionWarningEndDate>
    {
        public Task Handle(UserLoginToSubscriptionWarningEndDate notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}