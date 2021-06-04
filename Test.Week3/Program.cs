using System;
using System.Collections;
using System.Collections.Generic;
using Test.Week3.Classi;
using Test.Week3.Classi.SottoClassi_Prodotti;

namespace Test.Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Accesso tramite credenziali al menù:
            //- creo una lista di utenti registrati
            //- faccio un cerca utente
            //- se utente trovato allora menù
            ArrayList mycarrello = new ArrayList();
            var utentiRegistrati = new List<Utente>()
            {
                new Utente("Laura.Pennetta", "5898", "Laura Pennetta"),
                new Utente("Ludovica.Pennetta", "4200", "Ludovica Pennetta"),
                new Utente("Alessandro.Pennetta", "18767", "Alessandro Pennetta"),
                new Utente("Claudia.Inguscio", "3569", "Claudia Inguscio"),
                new Utente("Silvia.Cola", "1310", "Silvia Cola"),
                new Utente("Flaminia.Ambrosini", "12998", "Flaminia Ambrosini"),
                new Utente("Marco.Barbieri", "16598", "Marco Barbieri"),
                new Utente("Mauro.Monti", "18698", "Mauro Monti"),
                new Utente("Dil.Singh", "17798", "Dilpreet Singh"),
                new Utente("Niccolo.Morgante", "2299", "Niccolo Morgante"),
                new Utente("Chiara.Draghini", "27898", "Chiara Draghini"),
                new Utente("Bianca.Nardone", "17599", "Bianca Nardone"),
            };
            Utente uRegistrato = Gestione.CercaUtente(utentiRegistrati);
            //visualizzazione del menù
            try
            {
                bool cicli = true;
                while (cicli)
                {
                    int scelta = Menu();
                    AnalisiScelta(scelta, cicli, mycarrello);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Utente non trovato, userName o password non validi.");
                Console.WriteLine("Riprova.");
            }
            //shopping
            //pagamento
        }

        public static int Menu()
        {
            int scelta;
            Console.WriteLine("1. Aggiungi uno o più prodotti al carrello");
            Console.WriteLine("2. Elimina uno o più prodotti dal carrello");
            Console.WriteLine("3. Modifica la quantità di un prodotto già inserito");
            Console.WriteLine("4. Riepilogo Carrello");
            Console.WriteLine("5. Exit");
            try
            {
                scelta = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                scelta = 0;
            }
            return scelta;
        }

        private static void AnalisiScelta(int scelta, bool cicli, ArrayList mycarrello)
        {
            switch (scelta)
            {
                case 1:
                    //Aggiungi uno o più prodotti al carrello
                    bool cicli2 = true;
                    while (cicli2)
                    {
                        int scelta2 = MenùSpesa();
                        AnalisiMenu(scelta2, cicli2, mycarrello);
                    }
                    break;
                case 2:
                    //Elimina uno o più prodotti dal carrello
                    break;
                case 3:
                    //Modifica la quantità di un prodotto già inserito
                    break;
                case 4:
                    //Riepilogo Carrello
                    break;
                case 0://gestisce l'eccezione
                    break;
                default:
                    cicli = false;
                    Console.WriteLine("Arrivederci!");
                    break;
            }
        }

        private static void AnalisiMenu(int scelta2, bool cicli2, ArrayList mycarrello)
        {
            switch (scelta2)
            {
                case 1:
                    Abbigliamento.MostraProdotti();
                    int sceltaA = Abbigliamento.SceltaCodice();
                    Abbigliamento abito = Abbigliamento.ProdottoSelezionato(sceltaA);
                    Console.WriteLine("Inserisci la quantità che desideri acquistare:");
                    try
                    {
                        abito.Quantita = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        abito.Quantita = 0;
                    }
                    Console.WriteLine("Inserisci la taglia che desideri acquistare:");
                    abito.Taglia = Console.ReadLine();
                    mycarrello.Add(abito);
                    break;
                case 2:
                    Alimenti.MostraProdotti();
                    int sceltaAl = Alimenti.SceltaCodice();
                    Alimenti cibo = Alimenti.PodottoSelezionato(sceltaAl);
                    Console.WriteLine("Inserisci la quantità che desideri acquistare:");
                    try
                    {
                        cibo.Quantita = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        cibo.Quantita = 0;
                    }
                    mycarrello.Add(cibo);
                    break;
                case 3:
                    OggettiElettronica.MostraProdotti();
                    int sceltaOE = OggettiElettronica.SceltaCodice();
                    OggettiElettronica oe = OggettiElettronica.ProdottoSelezionato(sceltaOE);
                    Console.WriteLine("Inserisci la quantità che desideri acquistare:");
                    try
                    {
                        oe.Quantita = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        oe.Quantita = 0;
                    }
                    mycarrello.Add(oe);
                    break;
                case 0://gestisce l'eccezione
                    break;
                default:
                    cicli2 = false;
                    Console.WriteLine("Arrivederci!");
                    break;
            }
        }

        private static int MenùSpesa()
        {
            int scelta;
            Console.WriteLine("\t\tSHOP\t\t");
            Console.WriteLine();
            Console.WriteLine("1. Menù Abbigliamento");
            Console.WriteLine("2. Menù Alimentare");
            Console.WriteLine("3. Menù Oggetti di Elettronica");
            Console.WriteLine("4. Exit");
            try
            {
                scelta = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                scelta = 0;
            }
            return scelta;
        }
    }
}
