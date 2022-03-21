﻿// <auto-generated />
using System;
using Intense.EFDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Intense.EFDataAccess.Migrations
{
    [DbContext(typeof(IntenseContext))]
    [Migration("20220321050940_initial migration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Intense.Domain.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Candidates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDay = new DateTime(1987, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "amber.leuschke@predovic.us",
                            FirstName = "Casimer",
                            LastName = "Ward",
                            PhoneNumber = "229-964-2801 x72460"
                        },
                        new
                        {
                            Id = 2,
                            BirthDay = new DateTime(1984, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "gertrude_vandervort@bodeklocko.co.uk",
                            FirstName = "Camron",
                            LastName = "Gerhold",
                            PhoneNumber = "1-425-819-0475"
                        },
                        new
                        {
                            Id = 3,
                            BirthDay = new DateTime(1983, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "laurence_jerde@greenfelder.uk",
                            FirstName = "Maddison",
                            LastName = "Labadie",
                            PhoneNumber = "(849)543-9825"
                        },
                        new
                        {
                            Id = 4,
                            BirthDay = new DateTime(1987, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "christina@raukunze.com",
                            FirstName = "Ralph",
                            LastName = "Toy",
                            PhoneNumber = "556.023.5643 x009"
                        },
                        new
                        {
                            Id = 5,
                            BirthDay = new DateTime(1989, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "eleonore.gottlieb@wintheiser.biz",
                            FirstName = "Maverick",
                            LastName = "Boehm",
                            PhoneNumber = "399-081-1875 x59380"
                        },
                        new
                        {
                            Id = 6,
                            BirthDay = new DateTime(1999, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nathanael@walter.com",
                            FirstName = "Lenora",
                            LastName = "Nader",
                            PhoneNumber = "1-189-101-6861 x51174"
                        },
                        new
                        {
                            Id = 7,
                            BirthDay = new DateTime(1980, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lila_kuphal@vandervort.name",
                            FirstName = "Lempi",
                            LastName = "Ratke",
                            PhoneNumber = "1-529-024-4782 x8618"
                        },
                        new
                        {
                            Id = 8,
                            BirthDay = new DateTime(1991, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "deanna_halvorson@hettingerschroeder.uk",
                            FirstName = "Tara",
                            LastName = "Keeling",
                            PhoneNumber = "384.905.3046"
                        },
                        new
                        {
                            Id = 9,
                            BirthDay = new DateTime(1994, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "antonietta@vonrueden.name",
                            FirstName = "Francis",
                            LastName = "Schoen",
                            PhoneNumber = "422-531-3831"
                        });
                });

            modelBuilder.Entity("Intense.Domain.CandidateSkill", b =>
                {
                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("CandidateId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("CandidateSkills");

                    b.HasData(
                        new
                        {
                            CandidateId = 1,
                            SkillId = 1
                        },
                        new
                        {
                            CandidateId = 1,
                            SkillId = 3
                        },
                        new
                        {
                            CandidateId = 1,
                            SkillId = 4
                        },
                        new
                        {
                            CandidateId = 2,
                            SkillId = 2
                        },
                        new
                        {
                            CandidateId = 2,
                            SkillId = 1
                        },
                        new
                        {
                            CandidateId = 2,
                            SkillId = 9
                        },
                        new
                        {
                            CandidateId = 2,
                            SkillId = 8
                        },
                        new
                        {
                            CandidateId = 4,
                            SkillId = 1
                        },
                        new
                        {
                            CandidateId = 4,
                            SkillId = 7
                        },
                        new
                        {
                            CandidateId = 4,
                            SkillId = 4
                        },
                        new
                        {
                            CandidateId = 5,
                            SkillId = 2
                        },
                        new
                        {
                            CandidateId = 3,
                            SkillId = 3
                        },
                        new
                        {
                            CandidateId = 3,
                            SkillId = 4
                        },
                        new
                        {
                            CandidateId = 5,
                            SkillId = 6
                        },
                        new
                        {
                            CandidateId = 7,
                            SkillId = 7
                        },
                        new
                        {
                            CandidateId = 7,
                            SkillId = 3
                        });
                });

            modelBuilder.Entity("Intense.Domain.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "java"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "php"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "c#"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "html"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "css"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "javascript"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "python"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "c"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "c++"
                        });
                });

            modelBuilder.Entity("Intense.Domain.CandidateSkill", b =>
                {
                    b.HasOne("Intense.Domain.Candidate", "Candidate")
                        .WithMany("CandidateSkills")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intense.Domain.Skill", "Skill")
                        .WithMany("CandidateSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("Intense.Domain.Candidate", b =>
                {
                    b.Navigation("CandidateSkills");
                });

            modelBuilder.Entity("Intense.Domain.Skill", b =>
                {
                    b.Navigation("CandidateSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
