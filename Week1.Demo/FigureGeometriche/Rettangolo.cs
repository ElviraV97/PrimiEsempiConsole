using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    class Rettangolo : Figura
    {
        public double Larghezza { get; set; }
        public double Altezza { get; set; }

        public double Area()
        {
            return Larghezza * Altezza;
        }

        public void Disegna()
        {
            Console.WriteLine($"Area rettangolo: " + Area() + "\tLarghezza: " + Larghezza +
                "\tAltezza: " + Altezza);
        }

        public override void SaveToFile(string fileName)
        {
            Console.WriteLine("Rettangolo salvato");
        }

        public override void LoadFromFile(string fileName)
        {
            Console.WriteLine("Rettangolo caricato");
        }

    }
}
