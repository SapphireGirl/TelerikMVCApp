using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using TelerikMvcApp.Models;

namespace TelerikMvcApp.DataAccess
{
    public class CandidateMappings : EntityTypeConfiguration<Candidate>
    {

        public CandidateMappings()
        {
            HasKey(x => x.Id);

            Property(p => p.FirstName).
                IsRequired().

                HasMaxLength(15);
               // HasColumnType("string");


            Property(p => p.LastName).
                IsRequired().

                HasMaxLength(25);
             //  HasColumnType("string");

            Property(p => p.Email).
                IsOptional().
                HasMaxLength(250);

            Property(p => p.TwitterHandle).
                IsOptional().
                HasMaxLength(250);
             //  HasColumnType("string");

            Property(p => p.Phone).
                IsRequired();
              // HasColumnType("string");

            // Date Created
            Property(p => p.DateEnteredSystem).
                HasColumnName("DateAdded").
                HasColumnOrder(5).
                //HasColumnType("date").
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Map<Candidate>(m => m.ToTable("Candidates"));

        }
    }

    public class QualificationsMappings : EntityTypeConfiguration<Qualification>
    {
        public QualificationsMappings()
        {
            HasKey(x => x.Id);
            HasRequired<Candidate>(s => s.Candidate)
                .WithMany(s => s.Qualifications)
                        .HasForeignKey(s => s.CandidateId);

            //Property(s => s.DateCompleted).IsOptional();
            //Property(p => p.QType).
            //    IsRequired();

            Property(x => x.Description)
                .HasMaxLength(250)
                .IsRequired();
            Map<Qualification>(m => m.ToTable("Qualifications"));
        }
    }
}

// For mapping doubles for Pricing
//Property(p => p.PricePerEach).HasPrecision(5, 2).IsOptional();