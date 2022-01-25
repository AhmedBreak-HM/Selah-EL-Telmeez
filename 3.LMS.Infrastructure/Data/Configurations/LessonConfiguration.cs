﻿using _0.LMS.Domain.AggregateModels.SubjectModels;
using _0.LMS.Domain.AggregateModels.UserModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LMS.Infrastructure.Data.Configurations
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.ToTable("Lessons");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(s => s.LessonName).HasColumnName("LessonName").HasMaxLength(50).IsRequired();
            builder.Property(s => s.IconOfList).HasColumnName("IconOfList");
            builder.Property(s => s.SubjectId).HasColumnName("SubjectId");
            builder.OwnsOne(x => x.LessonStudy, nameBuilder =>
            {
                nameBuilder.Property(p => p.UserPoints).HasColumnName("UserPoints");
                nameBuilder.Property(p => p.LessonPoints).HasColumnName("LessonPoints");
                nameBuilder.Property(p => p.Progress).HasColumnName("Progress");
            });
        }
    }
}