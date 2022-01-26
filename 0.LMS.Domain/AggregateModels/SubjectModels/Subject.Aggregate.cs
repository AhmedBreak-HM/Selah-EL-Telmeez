using _0.LMS.Domain.SeedWork;
using System.Collections.Generic;

namespace _0.LMS.Domain.AggregateModels.SubjectModels
{
    public class Subject : BaseEntity<int>, IAggregateRoot
    {
        public string SubjectName { get; private set; }
        public Icon Icon { get; private set; }
        public Grade Grade { get; private set; }
        public Term Term { get; private set; }
        public Guide Guide { get; private set; }
        public Point Point { get; private set; }
        public string Numeral { get; private set; }
        public bool Subscribed { get; private set; } = false;

        private readonly List<Lesson> _lessons;
        public IReadOnlyCollection<Lesson> Lessons => _lessons;

        private Subject()
        { }

        public Subject(int id, string subjectName, string iconOfList, int gradeId, int termId)
        {
            Id = id;
            SubjectName = subjectName;
            Icon = new Icon() { IconOfList = iconOfList };
            Grade = new Grade() { GradeId = gradeId };
            Term = new Term() { TermId = termId };
        }


    }
}