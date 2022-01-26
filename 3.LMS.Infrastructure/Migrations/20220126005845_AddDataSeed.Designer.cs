﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _3.LMS.Infrastructure.Data;

namespace _3.LMS.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220126005845_AddDataSeed")]
    partial class AddDataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "0c66ca49-ce4d-417a-b8b7-61f881631dc0",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "35283408-c936-4414-9670-9422b2d54e41",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "fe02a359-c1ff-4dcb-83fb-40a5f8e6138a",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "fc279c98-612b-4b5c-8eba-be57261c692b",
                            Name = "Parent",
                            NormalizedName = "PARENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("_0.LMS.Domain.AggregateModels.SubjectModels.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IconOfList")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IconOfList");

                    b.Property<string>("LessonName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LessonName");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int")
                        .HasColumnName("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("_0.LMS.Domain.AggregateModels.SubjectModels.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Numeral")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Numeral");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SubjectName");

                    b.Property<bool>("Subscribed")
                        .HasColumnType("bit")
                        .HasColumnName("Subscribed");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("_0.LMS.Domain.AggregateModels.UserModels.RecentLesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IconOfList")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IconOfList");

                    b.Property<string>("LessonName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LessonName");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int")
                        .HasColumnName("SubjectId");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserId1")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("UserId1");

                    b.ToTable("RecentLessons");
                });

            modelBuilder.Entity("_0.LMS.Domain.AggregateModels.SubscriptionModels.UserApplication", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<bool>("AcceptTerms")
                        .HasColumnType("bit");

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<int>("StudingYear")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubscirbedEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("YearOfBirth")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("UserApplication");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_0.LMS.Domain.AggregateModels.SubjectModels.Lesson", b =>
                {
                    b.HasOne("_0.LMS.Domain.AggregateModels.SubjectModels.Subject", "Subject")
                        .WithMany("Lessons")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("_0.LMS.Domain.AggregateModels.SubjectModels.LessonStudy", "LessonStudy", b1 =>
                        {
                            b1.Property<int>("LessonId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("LessonPoints")
                                .HasColumnType("int")
                                .HasColumnName("LessonPoints");

                            b1.Property<double>("Progress")
                                .HasColumnType("float")
                                .HasColumnName("Progress");

                            b1.Property<double>("UserPoints")
                                .HasColumnType("float")
                                .HasColumnName("UserPoints");

                            b1.HasKey("LessonId");

                            b1.ToTable("Lessons");

                            b1.WithOwner()
                                .HasForeignKey("LessonId");
                        });

                    b.Navigation("LessonStudy");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("_0.LMS.Domain.AggregateModels.SubjectModels.Subject", b =>
                {
                    b.OwnsOne("_0.LMS.Domain.AggregateModels.SubjectModels.Grade", "Grade", b1 =>
                        {
                            b1.Property<int>("SubjectId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("GradeId")
                                .HasColumnType("int")
                                .HasColumnName("GradeId");

                            b1.Property<string>("GradeName")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("GradeName");

                            b1.HasKey("SubjectId");

                            b1.ToTable("Subjects");

                            b1.WithOwner()
                                .HasForeignKey("SubjectId");
                        });

                    b.OwnsOne("_0.LMS.Domain.AggregateModels.SubjectModels.Guide", "Guide", b1 =>
                        {
                            b1.Property<int>("SubjectId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("ParentGuid")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("ParentGuid");

                            b1.Property<string>("TeacherGuide")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("TeacherGuide");

                            b1.HasKey("SubjectId");

                            b1.ToTable("Subjects");

                            b1.WithOwner()
                                .HasForeignKey("SubjectId");
                        });

                    b.OwnsOne("_0.LMS.Domain.AggregateModels.SubjectModels.Icon", "Icon", b1 =>
                        {
                            b1.Property<int>("SubjectId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("ColoredIcon")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("ColoredIcon");

                            b1.Property<string>("IconBackground")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)")
                                .HasColumnName("IconBackground");

                            b1.Property<string>("IconOfList")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("IconOfList");

                            b1.Property<string>("IconOfSlider")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("IconOfSlider");

                            b1.HasKey("SubjectId");

                            b1.ToTable("Subjects");

                            b1.WithOwner()
                                .HasForeignKey("SubjectId");
                        });

                    b.OwnsOne("_0.LMS.Domain.AggregateModels.SubjectModels.Point", "Point", b1 =>
                        {
                            b1.Property<int>("SubjectId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<double>("StudentPoints")
                                .HasColumnType("float")
                                .HasColumnName("StudentPoints");

                            b1.Property<int>("SubjectPoints")
                                .HasColumnType("int")
                                .HasColumnName("SubjectPoints");

                            b1.HasKey("SubjectId");

                            b1.ToTable("Subjects");

                            b1.WithOwner()
                                .HasForeignKey("SubjectId");
                        });

                    b.OwnsOne("_0.LMS.Domain.AggregateModels.SubjectModels.Term", "Term", b1 =>
                        {
                            b1.Property<int>("SubjectId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("TermId")
                                .HasColumnType("int")
                                .HasColumnName("TermId");

                            b1.Property<string>("TermName")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)")
                                .HasColumnName("TermName");

                            b1.HasKey("SubjectId");

                            b1.ToTable("Subjects");

                            b1.WithOwner()
                                .HasForeignKey("SubjectId");
                        });

                    b.Navigation("Grade");

                    b.Navigation("Guide");

                    b.Navigation("Icon");

                    b.Navigation("Point");

                    b.Navigation("Term");
                });

            modelBuilder.Entity("_0.LMS.Domain.AggregateModels.UserModels.RecentLesson", b =>
                {
                    b.HasOne("_0.LMS.Domain.AggregateModels.SubjectModels.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_0.LMS.Domain.AggregateModels.SubscriptionModels.UserApplication", "User")
                        .WithMany("RecentLessons")
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("_0.LMS.Domain.AggregateModels.SubjectModels.LessonStudy", "LessonStudy", b1 =>
                        {
                            b1.Property<int>("RecentLessonId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("LessonPoints")
                                .HasColumnType("int")
                                .HasColumnName("LessonPoints");

                            b1.Property<double>("Progress")
                                .HasColumnType("float")
                                .HasColumnName("Progress");

                            b1.Property<double>("UserPoints")
                                .HasColumnType("float")
                                .HasColumnName("UserPoints");

                            b1.HasKey("RecentLessonId");

                            b1.ToTable("RecentLessons");

                            b1.WithOwner()
                                .HasForeignKey("RecentLessonId");
                        });

                    b.Navigation("LessonStudy");

                    b.Navigation("Subject");

                    b.Navigation("User");
                });

            modelBuilder.Entity("_0.LMS.Domain.AggregateModels.SubjectModels.Subject", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("_0.LMS.Domain.AggregateModels.SubscriptionModels.UserApplication", b =>
                {
                    b.Navigation("RecentLessons");
                });
#pragma warning restore 612, 618
        }
    }
}
