using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    class Cerchio : Figura
    {
        public int Raggio { get; set; }
        public int CentroX { get; set; }
        public int CentroY { get; set; }
        public override double Area()
        {
            return 2 * Raggio * 3.14;
        }

        public override void Disegna()
        {
            Console.WriteLine($"Area cerchio: " + Area() + "\tRaggio: " + Raggio);
        }

        public override void SaveToFile(string fileName)
        {
            Console.WriteLine("Cerchio salvato");
        }

        public override void LoadFromFile(string fileName)
        {
            Console.WriteLine("Cerchio caricato");
        }
    }
}
