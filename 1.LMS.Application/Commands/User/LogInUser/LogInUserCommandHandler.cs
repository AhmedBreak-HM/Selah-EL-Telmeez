using _0.LMS.Domain.AggregateModels.SubscriptionModels;
using _0.LMS.Domain.Events;
using _1.LMS.Application.Contracts;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _1.LMS.Application.Commands.User.LogInUser
{
    public class LogInUserCommandHandler : IRequestHandler<LogInUserCommand, LogInUserForReturnDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMediator _mediator;

        public LogInUserCommandHandler(IUserRepository userRepository, IMediator mediator)
        {
            _userRepository = userRepository;
            _mediator = mediator;
        }

        public async Task<LogInUserForReturnDto> Handle(LogInUserCommand request, CancellationToken cancellationToken)
        {
            LogInUserCommandValidator validations = new LogInUserCommandValidator();
            var result = await validations.ValidateAsync(request, cancellationToken);
            if (result.Errors.Any())
                throw new Exception("LogIn is not Valid");
            var userFromAggregate = new UserApplication();
            userFromAggregate.Login(request.UserName, request.Email, request.Password);
            var warningEndDateEvent = new UserLoginToSubscriptionWarningEndDate();
            warningEndDateEvent.TodayDate = DateTime.Now;
            await _mediator.Publish(warningEndDateEvent, cancellationToken);
            return await _userRepository.LogIn(request, cancellationToken);
        }
    }
}