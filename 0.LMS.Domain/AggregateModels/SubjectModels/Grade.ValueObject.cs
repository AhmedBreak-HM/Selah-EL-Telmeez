using _0.LMS.Domain.SeedWork;
using System.Collections.Generic;

namespace _0.LMS.Domain.AggregateModels.SubjectModels
{
    public class Grade : ValueObject
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return GradeId;
            yield return GradeName;

        }
    }


}
