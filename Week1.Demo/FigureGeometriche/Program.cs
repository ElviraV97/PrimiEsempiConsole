using System;

namespace FigureGeometriche
{
    class Program
    {
        private static string fileName;

        static void Main(string[] args)
        {
            Cerchio c = new Cerchio { Nome = "cerchio", Raggio = 2, CentroX = 3, CentroY = 4 };
            c.Disegna();

            Rettangolo r = new Rettangolo { Nome = "rettangolo", Altezza = 2, Larghezza = 3 };
            r.Disegna();

            Triangolo t = new Triangolo { Nome = "triangolo", Altezza = 2, Base = 3 };
            t.Disegna();

            IFileSerializable fileSerializable = new Cerchio { Nome = "cerchio", Raggio = 2, CentroX = 3, CentroY = 4 };
            fileSerializable.SaveToFile(fileName);
            fileSerializable.LoadFromFile(fileName);
            IFileSerializable fileSerializable1 = new Rettangolo { Nome = "rettangolo", Altezza = 2, Larghezza = 3 };
            fileSerializable1.SaveToFile(fileName);
        }
    }
}
