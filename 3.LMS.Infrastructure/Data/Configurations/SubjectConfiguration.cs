using _0.LMS.Domain.AggregateModels.SubjectModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _3.LMS.Infrastructure.Data.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("Subjects");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(s => s.SubjectName).HasColumnName("SubjectName").HasMaxLength(100).IsRequired();
            builder.Property(s => s.Numeral).HasColumnName("Numeral");
            builder.Property(s => s.Subscribed).HasColumnName("Subscribed");
            builder.OwnsOne(x => x.Icon, nameBuilder =>
            {
                nameBuilder.Property(p => p.IconOfList).HasColumnName("IconOfList").HasMaxLength(100);
                nameBuilder.Property(p => p.IconOfSlider).HasColumnName("IconOfSlider").HasMaxLength(100);
                nameBuilder.Property(p => p.ColoredIcon).HasColumnName("ColoredIcon").HasMaxLength(100);
                nameBuilder.Property(p => p.IconBackground).HasColumnName("IconBackground").HasMaxLength(50);
            });

            builder.OwnsOne(x => x.Grade, nameBuilder =>
            {
                nameBuilder.Property(p => p.GradeId).HasColumnName("GradeId");
                nameBuilder.Property(p => p.GradeName).HasColumnName("GradeName");
            });

            builder.Navigation(e => e.Grade).UsePropertyAccessMode(PropertyAccessMode.Field).AutoInclude();

            //builder.Navigation(nameof(Subject.Grade))
            //.UsePropertyAccessMode(PropertyAccessMode.Field) // Convention based -> will find field named "books"
            //.AutoInclude(); // Automatically include this in any query

            builder.OwnsOne(x => x.Term, nameBuilder =>
            {
                nameBuilder.Property(p => p.TermId).HasColumnName("TermId");
                nameBuilder.Property(p => p.TermName).HasColumnName("TermName").HasMaxLength(50);
            });
            builder.Navigation(e => e.Term).UsePropertyAccessMode(PropertyAccessMode.Field).AutoInclude();

            builder.OwnsOne(x => x.Guide, nameBuilder =>
            {
                nameBuilder.Property(p => p.TeacherGuide).HasColumnName("TeacherGuide");
                nameBuilder.Property(p => p.ParentGuid).HasColumnName("ParentGuid");
            });
            builder.Navigation(e => e.Guide).UsePropertyAccessMode(PropertyAccessMode.Field).AutoInclude();

            builder.OwnsOne(x => x.Point, nameBuilder =>
            {
                nameBuilder.Property(p => p.StudentPoints).HasColumnName("StudentPoints");
                nameBuilder.Property(p => p.SubjectPoints).HasColumnName("SubjectPoints");
            });
            builder.Navigation(e => e.Point).UsePropertyAccessMode(PropertyAccessMode.Field).AutoInclude();

        }
    }
}