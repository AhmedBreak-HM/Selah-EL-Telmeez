using MediatR;
using System.Collections.Generic;

namespace _1.LMS.Application.Queries.Subject.GetSubjectByUser
{
    public class GetSubjectByUserQuery : IRequest<IReadOnlyList<GetSubjectByUserDto>>
    {
        public int GradeId { get; set; }
        public int TermId { get; set; }
    }
}