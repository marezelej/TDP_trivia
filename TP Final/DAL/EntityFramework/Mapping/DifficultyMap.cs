using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework.Mapping
{
    class DifficultyMap : EntityTypeConfiguration<Difficulty>
    {
        public DifficultyMap()
        {
            HasKey(pDifficulty => pDifficulty.Id);

            Property(pDifficulty => pDifficulty.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(pDifficulty => pDifficulty.Description)
                .HasMaxLength(30)
                .IsRequired();

            Property(pDifficulty => pDifficulty.Weight)
                .IsRequired();

            HasRequired(pDifficulty => pDifficulty.Set)
                .WithMany()
                .WillCascadeOnDelete(false);
        }
    }
}
