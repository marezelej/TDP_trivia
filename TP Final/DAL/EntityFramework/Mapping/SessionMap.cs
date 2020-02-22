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

            Property(pSession => pSession.Quantity)
                .IsRequired();

            Property(pSession => pSession.Time)
                .IsRequired();

            HasRequired(pSession => pSession.User)
                .WithMany()
                .WillCascadeOnDelete(false);

            HasRequired(pSession => pSession.Set)
                .WithMany()
                .WillCascadeOnDelete(false);

            HasRequired(pSession => pSession.Category)
                .WithMany()
                .WillCascadeOnDelete(false);

            HasRequired(pSession => pSession.Difficulty)
                .WithMany()
                .WillCascadeOnDelete(false);
        }
    }
}
