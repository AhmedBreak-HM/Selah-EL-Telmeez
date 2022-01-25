using _0.LMS.Domain.SeedWork;
using System.Collections.Generic;

namespace _0.LMS.Domain.AggregateModels.SubjectModels
{
    public class Point : ValueObject
    {
        public double StudentPoints { get; set; }
        public int SubjectPoints { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return StudentPoints;
            yield return SubjectPoints;
        }
    }
}