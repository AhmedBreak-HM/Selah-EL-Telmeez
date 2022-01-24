using _0.LMS.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public IReadOnlyCollection<Lesson> Lessons => _lessons.AsReadOnly();
        public Subject() { }
        public Subject(string subjectName, Icon icon, Grade grade, Term term, Guide guide, Point point, string numeral, bool subscribed)
        {
            SubjectName = subjectName;
            Icon = icon;
            Grade = grade;
            Term = term;
            Guide = guide;
            Point = point;
            Numeral = numeral ?? "Hindi";
            Subscribed = subscribed;
            _lessons = new List<Lesson>();
        }
    }


}
