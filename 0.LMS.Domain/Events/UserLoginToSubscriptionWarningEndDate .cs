using _0.LMS.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.LMS.Domain.Events
{
    public class UserLoginToSubscriptionWarningEndDate : IDomainEvent
    {
        public DateTime TodayDate { get; set; }

    }
}
