using _0.LMS.Domain.AggregateModels.SubjectModels;
using _0.LMS.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.LMS.Domain.AggregateModels.UserModels
{
    public class RecentLesson : BaseEntity<int>
    {
        public string LessonName { get; private set; }
        public string IconOfList { get; private set; }
        public LessonStudy LessonStudy { get; private set; }
        public int SubjectId { get; private set; }
        public int UserId { get; private set; }
        public RecentLesson()
        {

        }
        public RecentLesson(string lessonName, string iconOfList, LessonStudy lessonStudy, int subjectId, int userId)
        {
            LessonName = lessonName;
            IconOfList = iconOfList;
            LessonStudy = lessonStudy;
            SubjectId = subjectId;
            UserId = userId;
        }
    }
}
