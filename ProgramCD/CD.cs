using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCD
{
    internal class CD
    {

        public string _titolo {

            get { return _titolo; }

            private set
            {
                _titolo = value;
            }

        }
        private string autore;
        private List<Brano> listaBrani;

        public CD(string titolo, string autore)
        {
            _titolo = titolo;
            _autore = autore;
            listaBrani = new List<Brano>(); // Lista Brani
        }

        public string GetTitolo { get { return _titolo; } }
        public string GetAutore { get { return _autore; } }

        public void SetTitolo(string t) { _titolo = t; }
        public void SetAutore(string a) { _autore = a; }

        public void AggiungiBrano(Brano b)
        {
            listaBrani.Add(b);
        }

        public ProgrmaCD(string _titolo; string _autore; List<Brano> Lista_Brani) 
            {
            public string Titolo 
            { get; set; }
    }

            




    }

