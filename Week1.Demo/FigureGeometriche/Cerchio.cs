using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    class Cerchio : Figura
    {
        public double Raggio { get; set; }
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
            try
            {
                using StreamWriter writer = File.CreateText($"C://Users/elvira.verrengia//Desktop//EsempioFileWatcher//{fileName}");
                string instanceData = $"Values:{Nome};{CentroX};{CentroY};{Raggio}";

                writer.WriteLine(instanceData);
                writer.Close();
            } catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override void LoadFromFile(string fileName)
        {
            try
            {
                using StreamReader reader = File.OpenText($"C://Users//elvira.verrengia//Desktop//EsempioFileWatcher//{fileName}");
                string instanceData = reader.ReadLine().Split(":")[1];

                string[] values = instanceData.Split(";");

                Nome = values[0];

                bool resultOk = int.TryParse(values[1], out int x);
                if (resultOk)
                {
                    CentroX = x;
                }

                int.TryParse(values[2], out int y);
                CentroY = y;

                double.TryParse(values[3], out double raggio);
                Raggio = raggio;
                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

        }
    }
}
