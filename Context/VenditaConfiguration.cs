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
    public class VenditaConfiguration : IEntityTypeConfiguration<Vendita>
    {
        public void Configure(EntityTypeBuilder<Vendita> builder)
        {
            builder.ToTable("Vendita");
            builder.HasKey(k => k.NumeroVendita);
            builder.Property(e => e.Quantita).IsRequired();
            builder.Property("DataVendita").IsRequired().HasColumnType("datetime2");

            //collegamento con tabella prodotto
            builder.HasOne(r => r.Prodotto) //navigation property di vendita
                   .WithMany(t => t.Vendite) //list di vendite in PRODOTTO
                   .HasForeignKey(y => y.CodiceProdotto); //foreign key! IMPORTANTE CHE SIA DELLO STESSO TIPO DELLA PK DI PRODOTTO!(è STRINGA)
        }
    }
}
