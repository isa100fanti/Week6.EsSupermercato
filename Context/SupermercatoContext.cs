using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.SupermercatoEF.Model;

namespace Week6.SupermercatoEF.Context
{
    public class SupermercatoContext : DbContext
    {
        //estende db context
        //costruttore no arg vuoto
        public SupermercatoContext() : base()
        {

        }

        //Dbset 
        public DbSet<Reparto> Reparti { get; set; }
        public DbSet<Prodotto> Prodotti { get; set; }
        public DbSet<Dipendente> Dipendenti { get; set; }
        public DbSet<Vendita> Vendite { get; set; }

        //connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Persist Security Info = False; Integrated Security = true; 
                                    Initial Catalog = Supermercato; Server = .\SQLEXPRESS");
        }

        //metodo che mi serve per fare la chiamata ai vari config
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Reparto>(new RepartoConfiguration());
            modelBuilder.ApplyConfiguration<Dipendente>(new DipendenteConfiguration());
            modelBuilder.ApplyConfiguration<Prodotto>(new ProdottoConfiguration());
            modelBuilder.ApplyConfiguration<Vendita>(new VenditaConfiguration());


        }
    }
}
