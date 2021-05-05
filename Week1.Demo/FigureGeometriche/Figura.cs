using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    class Figura : IFileSerializable
    {
        public string Nome { get; set; }
        public virtual double Area()
        {
            return 0;
        }

        public virtual void Disegna()
        {}

        public virtual void SaveToFile(string fileName)
        {
            Console.WriteLine("File salvato");
        }

        public virtual void LoadFromFile(string fileName)
        {
            Console.WriteLine("File caricato");
        }
     }
}
