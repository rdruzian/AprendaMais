﻿using AprendaMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendaMais.Data
{
    public class PerguntaProvaConfiguration : IEntityTypeConfiguration<PerguntaProva>
    {
        public void Configure(EntityTypeBuilder<PerguntaProva> builder)
        {
            builder.
                ToTable("perguntaprova");
            builder.
                Property(d => d.ID_prova).
                    HasColumnName("id_prova").
                IsRequired();
            builder.
                Property(d => d.ID_pergunta).
                    HasColumnName("id_pergunta").
                IsRequired();
            builder.
                Property(d => d.ID_perguntaProva).
                    HasColumnName("id_perguntaprova").
                IsRequired();
            builder.
                HasKey(d => d.ID_perguntaProva);
        }
    }
}
