using _1.LMS.Application.Issues;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LMS.Infrastructure.Data.Seeds
{
    // Issue (⩺_⩹) : 0001
    public class SubjectModelOwnsOneMappingIssueSeeding : IEntityTypeConfiguration<SubjectModelOwnsOneMappingIssue>
    {
        public void Configure(EntityTypeBuilder<SubjectModelOwnsOneMappingIssue> builder)
        {
            builder.HasData(new SubjectModelOwnsOneMappingIssue[]{
                new SubjectModelOwnsOneMappingIssue(){ Id= 1, SubjectName="الجداول الزمنية",
                    IconOfList="http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                    GradeId = 1 ,TermId = 1},
                new SubjectModelOwnsOneMappingIssue(){ Id= 2, SubjectName="اللغة العربية",
                    IconOfList="http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                    GradeId = 1 ,TermId = 2},
                new SubjectModelOwnsOneMappingIssue(){ Id= 3, SubjectName="الجداول الزمنية",
                    IconOfList="http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                    GradeId = 1 ,TermId = 1},
                new SubjectModelOwnsOneMappingIssue(){ Id= 4, SubjectName="اللغة العربية",
                    IconOfList="http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                    GradeId = 1 ,TermId = 2},
                new SubjectModelOwnsOneMappingIssue(){ Id= 5, SubjectName="الجداول الزمنية",
                    IconOfList="http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                    GradeId = 2 ,TermId = 1},
                new SubjectModelOwnsOneMappingIssue(){ Id= 6, SubjectName="اللغة العربية",
                    IconOfList="http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                    GradeId = 2 ,TermId = 1},
                new SubjectModelOwnsOneMappingIssue(){ Id= 7, SubjectName="الجداول الزمنية",
                    IconOfList="http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                    GradeId = 2 ,TermId = 2},
                new SubjectModelOwnsOneMappingIssue(){ Id= 8, SubjectName="اللغة العربية",
                    IconOfList="http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                    GradeId = 2 ,TermId = 2},
            });
        }
    }
    // ------(⩺_⩹)-------
}
