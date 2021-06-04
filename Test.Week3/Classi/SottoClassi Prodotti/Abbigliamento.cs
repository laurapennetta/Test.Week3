using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Week3.Classi.SottoClassi_Prodotti
{
    public class Abbigliamento : Prodotti
    {
        public string Taglia { get; set; }
        public string Brand { get; set; }
        public override string ToString()
        {
            return base.ToString()+$"TAGLIA: {Taglia}\nBRAND: {Brand}";
        }
        private static IDictionary<int, Abbigliamento> abitiCaricati = CaricaMenuAbiti();

        private static IDictionary<int, Abbigliamento> CaricaMenuAbiti()
        {
            IDictionary<int, Abbigliamento> vestito = new Dictionary<int, Abbigliamento>()
            {
                [0] = new Abbigliamento() { Codice = 0, Descrizione = "Pantalone", Prezzo = 38.90, Sconto = 0.10, Brand = "Zara"},
                [1] = new Abbigliamento() { Codice = 1, Descrizione = "Maglione", Prezzo = 56.70, Sconto = 0.05, Brand = "H&M"},
                [2] = new Abbigliamento() { Codice = 2, Descrizione = "Camicia", Prezzo = 23.80, Sconto = 0.025, Brand = "Massimo Dutti"},
                [3] = new Abbigliamento() { Codice = 3, Descrizione = "Cappotto", Prezzo = 225.50, Sconto = 0.25, Brand = "Max Mara"}
            };
            return vestito;
        }
        public static void MostraProdotti()
        {
            Console.WriteLine("Lista di vestiti disponibili:");
            foreach (var item in abitiCaricati)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Descrizione} - {item.Value.Brand} - {item.Value.Prezzo} euro - {item.Value.Sconto*100}%");
            }
        }

        public static int SceltaCodice()
        {
            int codice;
            do
            {
                Console.WriteLine("Inserisci il codice prodotto");

            } while (!(Int32.TryParse(Console.ReadLine(), out codice)) || !abitiCaricati.ContainsKey(codice));
            return codice;
        }

        public static Abbigliamento ProdottoSelezionato(int codice)
        {
            var prodottoSelezionato = abitiCaricati[codice];
            return prodottoSelezionato;
        }
    }
}
