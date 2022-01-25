using _0.LMS.Domain.AggregateModels.SubjectModels;
using _1.LMS.Application.Contracts;
using _3.LMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3.LMS.Infrastructure.Repositories
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        private readonly ApplicationDbContext _context;

        public SubjectRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Subject>> GetSubjectByUser(int gradeId, int termId)
        {
            return await _context.Subjects.Where(s => s.Grade.GradeId == gradeId && s.Term.TermId == termId).ToListAsync();
        }
    }
}