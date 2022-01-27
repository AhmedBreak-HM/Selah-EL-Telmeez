using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.LMS.Application.Issues
{
    // Issue (⩺_⩹) : 0001-Subject-PersistenceLayer&&ApplicationLayer-Mapping
    public class SubjectModelOwnsOneMappingIssue
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string IconOfList { get; set; }
        public string IconOfSlider { get; set; }
        public string ColoredIcon { get; set; }
        public string IconBackground { get; set; }
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public int TermId { get; set; }
        public string TermName { get; set; }
        public string TeacherGuide { get; set; } = null;
        public string ParentGuid { get; set; } = null;
        public double StudentPoints { get; set; }
        public int SubjectPoints { get; set; }
        public string Numeral { get; set; }
        public bool Subscribed { get; set; }
    }
}
