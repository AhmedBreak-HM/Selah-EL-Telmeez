using _1.LMS.Application.Contracts;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _1.LMS.Application.Queries.Subject.GetSubjectByUser
{
    public class GetSubjectByUserQueryHandler : IRequestHandler<GetSubjectByUserQuery, IReadOnlyList<GetSubjectByUserDto>>
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly IMapper _mapper;

        public GetSubjectByUserQueryHandler(ISubjectRepository subjectRepository, IMapper mapper)
        {
            _subjectRepository = subjectRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<GetSubjectByUserDto>> Handle(GetSubjectByUserQuery request, CancellationToken cancellationToken)
        {
            var subjectFromRepo = await _subjectRepository.GetSubjectByUser(request.GradeId, request.TermId);
            return _mapper.Map<IReadOnlyList<GetSubjectByUserDto>>(subjectFromRepo);
        }
    }
}