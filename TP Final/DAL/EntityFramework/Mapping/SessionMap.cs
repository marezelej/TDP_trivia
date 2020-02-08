using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework.Mapping
{
    class SessionMap : EntityTypeConfiguration<Session>
    {
        public SessionMap()
        {
            HasKey(pSession => pSession.Id);

            Property(pSession => pSession.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(pSession => pSession.Score)
                .IsRequired();

            Property(pSession => pSession.Quantity)
                .IsRequired();

            Property(pSession => pSession.Time)
                .IsRequired();
        }
    }
}
