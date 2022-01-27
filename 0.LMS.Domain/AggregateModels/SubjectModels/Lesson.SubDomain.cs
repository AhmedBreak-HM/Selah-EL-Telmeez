using _0.LMS.Domain.SeedWork;

namespace _0.LMS.Domain.AggregateModels.SubjectModels
{
    public class Lesson : BaseEntity<int>
    {
        public string LessonName { get; private set; }
        public string IconOfList { get; private set; }
        public LessonStudy LessonStudy { get; private set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; private set; }

        private Lesson()
        { }

        public Lesson(string lessonName, string iconOfList, int subjectId)
        {
            LessonName = lessonName;
            IconOfList = iconOfList;
            SubjectId = subjectId;
        }
    }
}