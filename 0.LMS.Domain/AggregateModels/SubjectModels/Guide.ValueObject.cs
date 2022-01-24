using _0.LMS.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.LMS.Domain.AggregateModels.SubjectModels
{
    public class Guide : ValueObject
    {
        public string TeacherGuide { get; set; } = null;
        public string ParentGuid { get; set; } = null;
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return TeacherGuide;
            yield return ParentGuid;

        }
    }
}
