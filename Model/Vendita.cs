using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.SupermercatoEF.Model
{
    public class Vendita
    {
        public int NumeroVendita { get; set; }
        public int Quantita { get; set; }
        public DateTime DataVendita { get; set; }
        public Prodotto Prodotto { get; set; } //navigation property
        public String CodiceProdotto { get; set; } // deve corrispondere al codice che è stinga nel prodotto!
    }
}
