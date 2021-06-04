using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Week3.Classi.SottoClassi_Prodotti
{
    public class Alimenti : Prodotti
    {
        public string DataScadenza { get; set; }
        public override string ToString()
        {
            return base.ToString()+$"DATA DI SCADENZA: {DataScadenza}";
        }
        private static IDictionary<int, Alimenti> alimentiCaricati = CaricaMenuAlimenti();

        private static IDictionary<int, Alimenti> CaricaMenuAlimenti()
        {
            IDictionary<int, Alimenti> cibo = new Dictionary<int, Alimenti>()
            {
                [0] = new Alimenti() { Codice = 0, Descrizione = "Pasta", Prezzo = 2.00, Sconto = 0.10, DataScadenza = "07/07/2022"},
                [1] = new Alimenti() { Codice = 1, Descrizione = "1Kg Scottona", Prezzo = 56.70, Sconto = 0.05, DataScadenza = "08/06/2021"},
                [2] = new Alimenti() { Codice = 2, Descrizione = "Caviale", Prezzo = 23.80, Sconto = 0.025, DataScadenza = "09/09/2021"},
                [3] = new Alimenti() { Codice = 3, Descrizione = "Pacco Famiglia Kinder delice", Prezzo = 15.50, Sconto = 0.25, DataScadenza = "10/12/2022"}
            };
            return cibo;
        }
        public static void MostraProdotti()
        {
            Console.WriteLine("Lista di cibi disponibili:");
            foreach (var item in alimentiCaricati)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Descrizione} - Data di scadenza: {item.Value.DataScadenza} - {item.Value.Prezzo} euro - {item.Value.Sconto * 100}%");
            }
        }

        public static int SceltaCodice()
        {
            int codice;
            do
            {
                Console.WriteLine("Inserisci il codice prodotto");

            } while (!(Int32.TryParse(Console.ReadLine(), out codice)) || !alimentiCaricati.ContainsKey(codice));
            return codice;
        }

        internal static Alimenti PodottoSelezionato(int codice)
        {
            var prodottoSelezionato = alimentiCaricati[codice];
            return prodottoSelezionato;
        }
    }
}
