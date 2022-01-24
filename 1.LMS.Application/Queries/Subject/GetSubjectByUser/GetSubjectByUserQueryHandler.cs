using _1.LMS.Application.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.LMS.Application.Queries.Subject.GetSubjectByUser
{
    public class GetSubjectByUserQueryHandler : IRequestHandler<GetSubjectByUserQuery, GetSubjectByUserDto>
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly IMapper _mapper;

        public GetSubjectByUserQueryHandler(ISubjectRepository subjectRepository, IMapper mapper)
        {
            _subjectRepository = subjectRepository;
            _mapper = mapper;
        }
        public async Task<GetSubjectByUserDto> Handle(GetSubjectByUserQuery request, CancellationToken cancellationToken)
        {
            var subjectFromRepo = await _subjectRepository.GetSubjectByUser(request.GradeId, request.TermId, cancellationToken);
            return _mapper.Map<GetSubjectByUserDto>(subjectFromRepo);
        }
    }
}
