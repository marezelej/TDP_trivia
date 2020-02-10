using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework.Mapping
{
    class QuestionMap : EntityTypeConfiguration<Question>
    {
        public QuestionMap()
        {
            HasKey(pQuestion => pQuestion.Id);

            Property(pQuestion => pQuestion.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(pQuestion => pQuestion.Description)
                .HasMaxLength(1024)
                .IsRequired();

            HasRequired(pQuestion => pQuestion.Set)
                .WithMany()
                .WillCascadeOnDelete(false);

            HasRequired(pQuestion => pQuestion.Category)
                .WithMany()
                .WillCascadeOnDelete(false);

            HasRequired(pQuestion => pQuestion.Difficulty)
                .WithMany()
                .WillCascadeOnDelete(false);
        }
    }
}
