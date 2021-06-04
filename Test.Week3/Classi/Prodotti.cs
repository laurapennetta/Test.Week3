using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Week3.Classi
{
    public abstract class Prodotti
    {
        public int Codice { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public double Sconto { get; set; }
        public int Quantita { get; set; }
        public double PrezzoScontato { get { return Prezzo * Sconto; } }
        public override string ToString()
        {
            return $"CODICE DEL PRODOTTO: {Codice}\nDESCRIZIONE: {Descrizione}\nQUANTITA': {Quantita}\n" +
                $"PREZZO: {Prezzo}euro\nPREZZO SCONTATO: {PrezzoScontato}euro\n";
        }
    }
}
