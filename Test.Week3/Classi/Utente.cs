using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Week3.Classi
{
    public class Utente
    {
        public string _userName;
        public string _password;
        public string _nomeCognome;
        public Utente(string userName, string password, string nomeCognome)
        {
            _userName = userName;
            _password = password;
            _nomeCognome = nomeCognome;
        }
    }
}
