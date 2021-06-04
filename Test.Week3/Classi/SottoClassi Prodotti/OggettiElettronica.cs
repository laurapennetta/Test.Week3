using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Week3.Classi.SottoClassi_Prodotti
{
    public class OggettiElettronica : Prodotti
    {
        public string Produttore { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"PRODUTTORE: {Produttore}";
        }
        private static IDictionary<int, OggettiElettronica> oggettieCaricati = CaricaMenuOggettiE();

        private static IDictionary<int, OggettiElettronica> CaricaMenuOggettiE()
        {
            IDictionary<int, OggettiElettronica> oggetto = new Dictionary<int, OggettiElettronica>()
            {
                [0] = new OggettiElettronica() { Codice = 0, Descrizione = "Iphone 12", Prezzo = 982.00, Sconto = 0.10, Produttore = "Apple"},
                [1] = new OggettiElettronica() { Codice = 1, Descrizione = "Surface Laptop 3", Prezzo = 999.70, Sconto = 0.05, Produttore = "Microsoft"},
                [2] = new OggettiElettronica() { Codice = 2, Descrizione = "Cuffie AKG", Prezzo = 98.80, Sconto = 0.025, Produttore = "AKG" },
                [3] = new OggettiElettronica() { Codice = 3, Descrizione = "Televisore LG smart TV", Prezzo = 2600.50, Sconto = 0.25, Produttore = "LG"}
            };
            return oggetto;
        }
        public static void MostraProdotti()
        {
            Console.WriteLine("Lista di oggetti elettronici disponibili:");
            foreach (var item in oggettieCaricati)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Descrizione} - {item.Value.Produttore} - {item.Value.Prezzo} euro - {item.Value.Sconto * 100}%");
            }
        }

        internal static int SceltaCodice()
        {
            int codice;
            do
            {
                Console.WriteLine("Inserisci il codice prodotto");

            } while (!(Int32.TryParse(Console.ReadLine(), out codice)) || !oggettieCaricati.ContainsKey(codice));
            return codice;
        }

        internal static OggettiElettronica ProdottoSelezionato(int codice)
        {
            var prodottoSelezionato = oggettieCaricati[codice];
            return prodottoSelezionato;
        }
    }
}
