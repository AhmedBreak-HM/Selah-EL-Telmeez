using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.LMS.Application.Queries.User.GetUserByName
{
    public class GetUserByNameQuery : IRequest<UserForReturnDto>
    {
        public string UserName { get; set; }
    }
}
