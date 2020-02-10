using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework.Mapping
{
    class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            HasKey(pCategory => pCategory.Id);

            Property(pCategory => pCategory.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(pCategory => pCategory.Name)
                .HasMaxLength(30)
                .IsRequired();

            HasRequired(pCategory => pCategory.Set)
                .WithMany()
                .WillCascadeOnDelete(false);
        }
    }
}
