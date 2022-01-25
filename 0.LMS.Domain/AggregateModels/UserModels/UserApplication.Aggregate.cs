using _0.LMS.Domain.AggregateModels.UserModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

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

        public UserApplication()
        { }

        public UserApplication(int studingYear, int city, DateTime yearOfBirth, bool acceptTerms, DateTime subscirbedEndDate)
        {
            StudingYear = studingYear;
            City = city;
            YearOfBirth = yearOfBirth;
            AcceptTerms = acceptTerms;
            SubscirbedEndDate = subscirbedEndDate;
            _recentLesson = new List<RecentLesson>();
        }

        public bool Login(string userName, string email, string password)
        {
            Email = email ?? throw new ArgumentException("Must have a value", nameof(email));
            if (password == null) throw new ArgumentException("Must have a value", nameof(password));
            return true;
        }

        public void SignUp(string email, string userName, int studingYear, string password, string mobileNumber, DateTime yearOfBirth, int city, DateTime subscirbedEndDate)
        {
            Email = email ?? throw new ArgumentException("Must have a value", nameof(email));
            UserName = userName ?? throw new ArgumentException("Must have a value", nameof(userName));
            StudingYear = studingYear;
            if (password == null) throw new ArgumentException("Must have a value", nameof(password));
            PhoneNumber = mobileNumber;
            City = city;
            YearOfBirth = yearOfBirth;
            SubscirbedEndDate = subscirbedEndDate;
        }
    }
}