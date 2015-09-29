using eLearning.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLearning.Data.EF.Mappers
{
   public class TutorMapper : EntityTypeConfiguration<Tutor>
    {
        public TutorMapper()
        {
            this.ToTable("Tutors");

            this.HasKey(s => s.Id);
            this.Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(s => s.Id).IsRequired();

            this.Property(s => s.Email).IsRequired();
            this.Property(s => s.Email).HasMaxLength(255);
            this.Property(s => s.Email).IsUnicode(false);

            this.Property(s => s.UserName).IsRequired();
            this.Property(s => s.UserName).HasMaxLength(50);
            this.Property(s => s.UserName).IsUnicode(false);

            this.Property(s => s.Password).IsRequired();
            this.Property(s => s.Password).HasMaxLength(255);

            this.Property(s => s.FirstName).IsRequired();
            this.Property(s => s.FirstName).HasMaxLength(50);

            this.Property(s => s.LastName).IsRequired();
            this.Property(s => s.LastName).HasMaxLength(50);

            this.Property(s => s.Gender).IsOptional();
        }
    }
}


//Each “Course” has a “Subject”.
//Each “Tutor” can tech multiple “Courses”.
//Each “Student” can enroll in multiple “Courses”. So we’ll have Many-to-Many table to persist the relation called “Enrollment”.