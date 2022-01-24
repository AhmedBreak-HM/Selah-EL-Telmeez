using _0.LMS.Domain.SeedWork;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.LMS.Domain.AggregateModels.SubjectModels
{
    public class Lesson : BaseEntity<int>
    {

        public string LessonName { get; private set; }
        public string IconOfList { get; private set; }
        public LessonStudy LessonStudy { get; private set; }
        public int SubjectId { get; private set; }

        public Lesson() { }
        public Lesson(string lessonName, string iconOfList, LessonStudy lessonStudy, int subjectId)
        {
            LessonName = lessonName;
            IconOfList = iconOfList;
            LessonStudy = lessonStudy;
            SubjectId = subjectId;
        }

    }
}
