using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Domain;

namespace TriviaGame.DAL.EntityFramework.Mapping
{
    class QuestionsSetMap : EntityTypeConfiguration<QuestionsSet>
    {
        public QuestionsSetMap()
        {
            HasKey(pSet => pSet.Id);

            Property(pSet => pSet.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(pSet => pSet.Name)
                .HasMaxLength(30)
                .IsRequired();

            Property(pSet => pSet.MaxQuantity)
                .IsRequired();
        }
    }
}
