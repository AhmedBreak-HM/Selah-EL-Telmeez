using _0.LMS.Domain.AggregateModels.SubscriptionModels;
using _1.LMS.Application.Contracts;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _1.LMS.Application.Commands.User.SignUpUser
{
    public class SignUpUserCommandHandler : IRequestHandler<SignUpUserCommand, IdentityResult>
    {
        private readonly IUserRepository _userRepository;

        public SignUpUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IdentityResult> Handle(SignUpUserCommand request, CancellationToken cancellationToken)
        {
            SignUpUserCommandValidator validations = new SignUpUserCommandValidator();
            var result = await validations.ValidateAsync(request, cancellationToken);
            if (result.Errors.Any())
                throw new Exception("SignUpUser is not Valid");
            var userFromAggregate = new UserApplication();
            userFromAggregate.SignUp(request.Email, request.UserName, request.StudingYear, request.Password,
                                     request.MobileNumber, request.YearOfBirth, request.City, request.SubscirbedEndDate);
            return await _userRepository.SignUp(request, cancellationToken);
        }
    }
}