using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Domain;

namespace TriviaGame.DAL.EntityFramework.Mapping
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

            Property(pSession => pSession.Time)
                .IsRequired();

            Property(pSession => pSession.Timestamp)
                .IsRequired();

            HasRequired(pSession => pSession.User)
                .WithMany()
                .WillCascadeOnDelete(false);
        }
    }
}
