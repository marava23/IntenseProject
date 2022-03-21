using Intense.Domain;
using Intense.EFDataAccess.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intense.EFDataAccess
{
    public class IntenseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-AUKHI58;Initial Catalog=Intense;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CandidateConfiguration());
            modelBuilder.ApplyConfiguration(new SkillConfiguration());
            modelBuilder.Entity<CandidateSkill>().HasKey(x => new { x.CandidateId, x.SkillId });
            base.OnModelCreating(modelBuilder);

            var skills = new List<Skill>
            {
                new Skill
                {
                    Id =1,
                    Name = "java"
                },
                new Skill
                {
                    Id = 2,
                    Name = "php"
                },
                new Skill
                {
                    Id = 3,
                    Name = "c#"
                },
                new Skill
                {
                    Id=4,
                    Name = "html"
                },
                new Skill
                {
                    Id = 5,
                    Name = "css"
                },
                new Skill
                {
                    Id=6,
                    Name = "javascript"
                },
                new Skill
                {
                    Id=7,
                    Name = "python"
                },
                new Skill
                {
                    Id = 8,
                    Name = "c"
                },
                new Skill
                {
                    Id = 9,
                    Name = "c++"
                }
            };
            modelBuilder.Entity<Skill>().HasData(skills);

            var candidates = new List<Candidate>();
            {
                for (int i = 1; i < 10; i++)
                {
                    var rnd = new Random();
                    var date = new DateTime(rnd.Next(1980, 2000), rnd.Next(1, 12), rnd.Next(1, 28));
                    candidates.Add(new Candidate
                    {
                        Id = i,
                        FirstName = Faker.Name.First(),
                        LastName = Faker.Name.Last(),
                        BirthDay = date,
                        Email = Faker.Internet.Email(),
                        PhoneNumber = Faker.Phone.Number()
                    });
                }

            };

            modelBuilder.Entity<Candidate>().HasData(candidates);

            var candidateSkill = new List<CandidateSkill> {
                new CandidateSkill
                {
                    SkillId=1,
                    CandidateId=1
                },
                new CandidateSkill
                {
                    SkillId=3,
                    CandidateId=1
                },
                new CandidateSkill
                {
                    SkillId=4,
                    CandidateId=1
                },
                new CandidateSkill
                {
                    SkillId=2,
                    CandidateId=2
                },
                new CandidateSkill
                {
                    SkillId=1,
                    CandidateId=2
                },
                new CandidateSkill
                {
                    SkillId=9,
                    CandidateId=2
                },
                new CandidateSkill
                {
                    SkillId=8,
                    CandidateId=2
                },
                new CandidateSkill
                {
                    SkillId=1,
                    CandidateId=4
                },
                new CandidateSkill
                {
                    SkillId=7,
                    CandidateId=4
                },
                new CandidateSkill
                {
                    SkillId=4,
                    CandidateId=4
                },
                new CandidateSkill
                {
                    SkillId=2,
                    CandidateId=5
                },
                new CandidateSkill
                {
                    SkillId=3,
                    CandidateId=3
                },
                new CandidateSkill
                {
                    SkillId=4,
                    CandidateId=3
                },
                new CandidateSkill
                {
                    SkillId=6,
                    CandidateId=5
                },
                new CandidateSkill
                {
                    SkillId=7,
                    CandidateId=7
                },
                new CandidateSkill
                {
                    SkillId=3,
                    CandidateId=7
                },

            };
            modelBuilder.Entity<CandidateSkill>().HasData(candidateSkill);
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is Entity e)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            e.CreatedAt = DateTime.Now;
                            e.UpdatedAt = null;
                            break;

                        case EntityState.Modified:
                            e.UpdatedAt = DateTime.Now;
                            break;

                        case EntityState.Deleted:
                            Entry(e).State = EntityState.Modified;
                            e.DeletedAt = DateTime.Now;
                            break;
                    }
                }

            }

            return base.SaveChanges();
        }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<CandidateSkill> CandidateSkills { get; set; }
    }
}
