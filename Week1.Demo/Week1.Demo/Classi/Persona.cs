using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Demo.Interfacce;

namespace Week1.Demo.Classi
{
    public class Persona : IEntita
    {
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public DateTime DataNascita { get; set; }

        public virtual string ToString()
        {
            return "Nome: " + Nome + " Cognome: " + Cognome + 
                " Data di nascita: " + DataNascita.ToShortDateString()
                +" Età:  " + Eta;
        }

        private int Eta1()
        {
            return DateTime.Today.Year - DataNascita.Year;
        }

        public string CalcolaCodiceFiscale()
        {
            return "lala";
            //return Nome.Substring(0, 3) + Cognome.Substring(0, 3) + DataNascita.Year;
        }

        public int Eta
        {
            get
            {
                return DateTime.Today.Year - DataNascita.Year;
            }
        }
    }
}
