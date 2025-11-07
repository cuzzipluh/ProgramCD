using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCD
{
    internal class Brano
    {
        public string Titolo {  get; set; }
        public string Autore { get; set; }
        public double Durata { get; set; }

        public string getTitolo()
        {
           return Titolo;
        }

        public string getAutore()
        {
            return Autore;
        }

        public double getDurata()
        {
            return Durata;
        }
        public void setTitolo(string nuovoTitolo)
        {
            Titolo = nuovoTitolo;
        }

        public void setAutore(string nuovoAutore)
        {
            Autore = nuovoAutore;
        }

        public void setDurata(double nuovaDurata)
        {
            if (Durata < 0)
            {
                throw new Exception("La durata deve essere maggiore di 0");
            }
            Durata = nuovaDurata;
        }

        public string ToString()
        {
            return $"Brano: {Titolo} | Autore: {Autore} | Durata: {Durata}";
        }

        public bool ShortSong(double maxDurata)
        {
            return Durata < maxDurata;
        }
    }
}
