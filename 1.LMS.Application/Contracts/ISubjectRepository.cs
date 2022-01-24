using _0.LMS.Domain.AggregateModels.SubjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.LMS.Application.Contracts
{
    public interface ISubjectRepository : IAsyncRepository<Subject>
    {
        Task<IReadOnlyList<Subject>> GetSubjectByUser(int gradeId, int termId, CancellationToken cancellationToken);
    }
}
