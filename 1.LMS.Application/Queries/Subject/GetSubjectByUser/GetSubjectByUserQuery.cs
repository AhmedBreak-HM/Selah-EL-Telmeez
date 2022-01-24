using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.LMS.Application.Queries.Subject.GetSubjectByUser
{
    public class GetSubjectByUserQuery : IRequest<GetSubjectByUserDto>
    {
        public int GradeId { get; set; }
        public int TermId { get; set; }

    }
}
