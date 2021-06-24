using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.SupermercatoEF.Model;

namespace Week6.SupermercatoEF.Context
{
    public class DipendenteConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Dipendente>
    {
        public void Configure(EntityTypeBuilder<Dipendente> builder)
        {
            //to table è il primo
            builder.ToTable("Dipendente");
            builder.HasKey(k => k.Codice);
            builder.Property("Codice").IsFixedLength().HasMaxLength(5);
            builder.Property("Nome").HasMaxLength(10)
                                    .IsRequired();
            builder.Property(c => c.Cognome).HasMaxLength(10)
                                            .IsRequired();
            builder.Property(d => d.DataNascita).HasColumnType("datetime2")
                                               .IsRequired();

            //collegamento con teparto
            builder.HasOne(r => r.Reparto)  //con la navigation property reparto IN DIPENDENTE
                   .WithMany(g => g.Dipendenti) //collection  di REPARTO
                   .HasForeignKey(e => e.RepartoNumero); //foreign key di DIPENDENTE
        }
    }
}
