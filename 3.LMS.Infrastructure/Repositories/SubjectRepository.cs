using _0.LMS.Domain.AggregateModels.SubjectModels;
using _1.LMS.Application.Contracts;
using _3.LMS.Infrastructure.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3.LMS.Infrastructure.Repositories
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public SubjectRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<Subject>> GetSubjectByUser(int gradeId, int termId)
        {
            // Issue (⩺_⩹) : 0001

            var subjects = await _context.SubjectsWrapper.Where(s => s.GradeId == gradeId && s.TermId == termId).ToListAsync();
            return _mapper.Map<IReadOnlyList<Subject>>(subjects);
            // ------(⩺_⩹)-------

            //return await _context.Subjects.Where(s => s.Grade.GradeId == gradeId && s.Term.TermId == termId).ToListAsync();
        }
    }
}