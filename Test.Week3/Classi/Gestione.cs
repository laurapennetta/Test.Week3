using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Week3.Classi
{
    public class Gestione
    {
        public static Utente CercaUtente(List<Utente> utentiRegistrati)
        {
            Console.WriteLine("Benvenuto!");
            Console.WriteLine("Per accedere al Menù dovrai inserire le tue credenziali.");
            Console.WriteLine("Quindi, premere invio per fare il login.");
            Console.ReadLine();
            Console.WriteLine("Digitare l'UserName:");
            string userName = Console.ReadLine();
            Console.WriteLine("Digitare la password:");
            string password = Console.ReadLine();
            foreach (Utente u in utentiRegistrati)
            {
                if (u._userName == userName && u._password == password)
                {
                    return u;
                }
            }
            return null;
        }
    }
}
