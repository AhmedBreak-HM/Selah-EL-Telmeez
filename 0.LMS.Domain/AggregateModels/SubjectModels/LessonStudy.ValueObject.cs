using _0.LMS.Domain.SeedWork;
using System.Collections.Generic;

namespace _0.LMS.Domain.AggregateModels.SubjectModels
{
    public class LessonStudy : ValueObject
    {
        public double UserPoints { get; set; }
        public int LessonPoints { get; set; }
        public double Progress { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return UserPoints;
            yield return LessonPoints;
            yield return Progress;
        }
    }
}