using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCD
{
    internal class CD
    {
       
            private string titolo;
            private string autore;
            private List<Brano> listaBrani;

        public CD(string titolo, string autore)
        {
            this.titolo = titolo;
            this.autore = autore;
            listaBrani = new List<Brano>(); // Lista Brani
        }

        public string GetTitolo { get { return titolo; } }
        public string GetAutore { get { return autore; } }

        public void SetTitolo(string t) { titolo = t; }
        public void SetAutore(string a) { autore = a; }

        public void AggiungiBrano(Brano  b)
        {
            listaBrani.Add(b);
        }

    }
}
