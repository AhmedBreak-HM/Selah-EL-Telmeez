using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.LMS.Application.Queries.Subject.GetSubjectByUser
{
    public class GetSubjectByUserDto
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        // IconOfList
        public string PhotoUrl { get; set; }
    }
}
