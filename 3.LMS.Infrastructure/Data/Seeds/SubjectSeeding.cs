using _0.LMS.Domain.AggregateModels.SubjectModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LMS.Infrastructure.Data.Seeds
{
    public class SubjectSeeding : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasData(new Subject[]
            {
                new Subject(1,"الجداول الزمنية",
                "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                3,2),
                new Subject(2,"اللغة العربية",
                "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                1,1),
                new Subject(3,"اللغة العربية",
                "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                1,2),
                new Subject(4,"اللغة العربية",
                "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                2,1),
                new Subject(5,"اللغة العربية",
                "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                2,2),
                new Subject(6,"اللغة العربية",
                "http://www.almoallem.com/media/LMSAPP/SubjectIcon/icon/studentPlan2.png",
                3,1),

            });
        }
    }
}
