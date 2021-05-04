using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    class Triangolo : Figura
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public override double Area()
        {
            return Base * Altezza * 1 / 2;
        }

        public override void Disegna()
        {
            Console.WriteLine($"Area triangolo: " + Area() + "\tBase: " + Base + "\tAltezza: " + Altezza);
        }
        public override void SaveToFile(string fileName)
        {
            Console.WriteLine("Triangolo salvato");
        }

        public override void LoadFromFile(string fileName)
        {
            Console.WriteLine("Triangolo caricato");
        }
    }
}
