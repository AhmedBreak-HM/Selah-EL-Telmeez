using _0.LMS.Domain.SeedWork;
using System.Collections.Generic;

namespace _0.LMS.Domain.AggregateModels.SubjectModels
{
    public class Icon : ValueObject
    {
        public string IconOfList { get; set; }
        public string IconOfSlider { get; set; }
        public string ColoredIcon { get; set; }
        public string IconBackground { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return IconOfList;
            yield return IconOfSlider;
            yield return ColoredIcon;
            yield return IconBackground;
        }
    }
}
