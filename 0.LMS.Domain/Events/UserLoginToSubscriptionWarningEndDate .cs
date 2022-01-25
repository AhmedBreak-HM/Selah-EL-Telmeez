using _0.LMS.Domain.SeedWork;
using System;

namespace _0.LMS.Domain.Events
{
    public class UserLoginToSubscriptionWarningEndDate : IDomainEvent
    {
        public DateTime TodayDate { get; set; }
    }
}