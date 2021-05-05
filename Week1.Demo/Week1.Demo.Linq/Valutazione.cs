using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Demo.Linq
{
    public class Valutazione
    {
        public string NomeStudente { get; set; }
        public DateTime DataValutazione { get; set; }
        public int Voto { get; set; }
        public Materia Materia { get; set; }
    }

    public enum Materia
    {
        Italiano,
        Matematica,
        Storia,
        Geografia
    }
}

