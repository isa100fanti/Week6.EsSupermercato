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
    public class ProdottoConfiguration : IEntityTypeConfiguration<Prodotto>
    {
        public void Configure(EntityTypeBuilder<Prodotto> builder)
        {
            builder.ToTable("Prodotto");
            builder.HasKey(k => k.Codice);
            builder.Property(t => t.Descrizione).HasMaxLength(15)
                                                .IsRequired();
            builder.Property("Prezzo").IsRequired();

            //collegamento con REPARTO E VENDITA
            builder.HasOne(r => r.Reparto) //navigation property, è importante andare avanti!senza mettere il ;
                   .WithMany(e => e.Prodotti)
                   .HasForeignKey(q => q.RepartoNumero); //foreign key
            
            //l'ho gia fatta in VENDITE il collegamento tra le tabelle!       


   
        }
    }
}
