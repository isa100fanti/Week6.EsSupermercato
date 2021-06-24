using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.SupermercatoEF.Model
{
    public class Prodotto
    {
        public String Codice { get; set; }
        public String Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public Reparto Reparto { get; set; } //NAVIGATION PROPERTY
        public int RepartoNumero { get; set; } //chiave
        public ICollection<Vendita> Vendite { get; set; } = new List<Vendita>();


    }
}
