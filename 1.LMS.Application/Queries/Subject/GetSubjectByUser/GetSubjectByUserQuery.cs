using MediatR;

namespace _1.LMS.Application.Queries.Subject.GetSubjectByUser
{
    public class GetSubjectByUserQuery : IRequest<GetSubjectByUserDto>
    {
        public int GradeId { get; set; }
        public int TermId { get; set; }
    }
}