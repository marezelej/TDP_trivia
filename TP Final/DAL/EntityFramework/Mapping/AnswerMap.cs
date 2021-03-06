﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Domain;

namespace TriviaGame.DAL.EntityFramework.Mapping
{
    class AnswerMap : EntityTypeConfiguration<Answer>
    {
        public AnswerMap()
        {
            HasKey(pAnswer => pAnswer.Id);

            Property(pAnswer => pAnswer.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(pAnswer => pAnswer.Description)
                .HasMaxLength(512)
                .IsRequired();

            Property(pAnswer => pAnswer.IsCorrect)
                .IsRequired();
        }
    }
}
