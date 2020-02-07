using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework.Mapping
{
    class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(pUser => pUser.Id);

            Property(pUser => pUser.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(pUser => pUser.FileNumber)
                .HasMaxLength(10)
                .IsRequired();

            this.Property(pUser => pUser.FirstName)
                .HasMaxLength(30)
                .IsRequired();

            this.Property(pUser => pUser.LastName)
                .HasMaxLength(30)
                .IsRequired();

            this.Property(pUser => pUser.Password)
                .HasMaxLength(30)
                .IsRequired();

            this.Property(pUser => pUser.IsAdmin)
                .IsRequired();

            this.HasMany(pUser => pUser.Sessions)
                .WithRequired();
        }
    }
}
