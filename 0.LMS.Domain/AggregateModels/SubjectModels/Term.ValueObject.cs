using _0.LMS.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.LMS.Domain.AggregateModels.SubjectModels
{
    public class Term : ValueObject
    {
        public int TermId { get; set; }
        public string TermName { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return TermId;
            yield return TermName;
        }
    }
}
