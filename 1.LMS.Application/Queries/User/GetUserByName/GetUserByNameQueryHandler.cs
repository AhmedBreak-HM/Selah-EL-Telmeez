using _1.LMS.Application.Contracts;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace _1.LMS.Application.Queries.User.GetUserByName
{
    public class GetUserByNameQueryHandler : IRequestHandler<GetUserByNameQuery, UserForReturnDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserByNameQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserForReturnDto> Handle(GetUserByNameQuery request, CancellationToken cancellationToken)
        {
            var userFromRepo = await _userRepository.GetUserByName(request.UserName);
            return _mapper.Map<UserForReturnDto>(userFromRepo);
        }
    }
}