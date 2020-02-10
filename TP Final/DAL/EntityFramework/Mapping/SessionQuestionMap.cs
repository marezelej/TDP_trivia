using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework.Mapping
{
    class SessionQuestionMap : EntityTypeConfiguration<SessionQuestion>
    {
        public SessionQuestionMap()
        {
            HasKey(pSessionQuestion => pSessionQuestion.Id);

            Property(pSession => pSession.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            
            Property(pSession => pSession.Time)
                .IsRequired();

            HasRequired(pSessionQuestion => pSessionQuestion.Session)
                .WithMany()
                .WillCascadeOnDelete(false);

            HasRequired(pSessionQuestion => pSessionQuestion.Question)
                .WithMany()
                .WillCascadeOnDelete(false);
        }
    }
}
