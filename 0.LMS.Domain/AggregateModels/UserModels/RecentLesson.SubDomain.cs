using _0.LMS.Domain.AggregateModels.SubjectModels;
using _0.LMS.Domain.AggregateModels.SubscriptionModels;
using _0.LMS.Domain.SeedWork;

namespace _0.LMS.Domain.AggregateModels.UserModels
{
    public class RecentLesson : BaseEntity<int>
    {
        public string LessonName { get; private set; }
        public string IconOfList { get; private set; }
        public LessonStudy LessonStudy { get; private set; }
        public Subject Subject { get; private set; }
        public int SubjectId { get; private set; }
        public UserApplication User { get; private set; }
        public int UserId { get; private set; }

        public RecentLesson()
        {
        }

        public RecentLesson(string lessonName, string iconOfList, int subjectId, int userId)
        {
            LessonName = lessonName;
            IconOfList = iconOfList;
            SubjectId = subjectId;
            UserId = userId;
        }
    }
}