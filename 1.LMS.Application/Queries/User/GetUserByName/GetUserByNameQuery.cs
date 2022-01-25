using MediatR;

namespace _1.LMS.Application.Queries.User.GetUserByName
{
    public class GetUserByNameQuery : IRequest<UserForReturnDto>
    {
        public string UserName { get; set; }
    }
}