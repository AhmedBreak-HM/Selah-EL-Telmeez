using _0.LMS.Domain.AggregateModels.UserModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.LMS.Domain.AggregateModels.SubscriptionModels
{
    public class UserApplication : IdentityUser
    {
        public int StudingYear { get; private set; }
        public int City { get; private set; }
        public DateTime YearOfBirth { get; private set; }
        public bool AcceptTerms { get; private set; }
        public DateTime SubscirbedEndDate { get; private set; }
        private readonly List<RecentLesson> _recentLesson;
        public IReadOnlyCollection<RecentLesson> RecentLessons => _recentLesson.AsReadOnly();

        public UserApplication(int studingYear, int city, DateTime yearOfBirth, bool acceptTerms, DateTime subscirbedEndDate)
        {
            StudingYear = studingYear;
            City = city;
            YearOfBirth = yearOfBirth;
            AcceptTerms = acceptTerms;
            SubscirbedEndDate = subscirbedEndDate;
            _recentLesson = new List<RecentLesson>();
        }

    }
}
