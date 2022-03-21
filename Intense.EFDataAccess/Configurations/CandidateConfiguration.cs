using Intense.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intense.EFDataAccess.Configurations
{
    public class CandidateConfiguration : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email).HasMaxLength(100).HasColumnType("varchar");
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.BirthDay).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(30).HasColumnType("varchar");

            builder.HasMany(x => x.CandidateSkills)
                .WithOne(x => x.Candidate)
                .HasForeignKey(x => x.CandidateId);
        }
    }
}
