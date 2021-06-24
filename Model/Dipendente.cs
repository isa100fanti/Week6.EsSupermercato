using System;

namespace Week6.SupermercatoEF.Model
{
    public class Dipendente
    {
        public String Codice { get; set; }
        public string Nome { get; set; }
        public String Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        //NAVIGATION PROPERTY di collegamento a reparto
        public int? RepartoNumero { get; set; } //se per caso il dipendente non è ancora associato
        public Reparto Reparto { get; set; }

    }
}
