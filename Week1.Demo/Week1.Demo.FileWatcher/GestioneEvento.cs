using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Demo.FileWatcher
{
    class GestioneEvento
    {
        public static void HandleNewTextFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Un nuovo file è stato creato {e.Name}");

            // Lettura del file
            using StreamReader reader = File.OpenText(e.FullPath);
            Console.WriteLine($"---Lettura di {e.Name} ---");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            // chiusura del flusso di lettura
            reader.Close();

            Console.WriteLine("Fine del contenuto");

            //Scrittura su file - se non esiste lo crea, se esiste lo apre e lo sovrascrive
            using StreamWriter writer = File.CreateText(@"C:\Users\elvira.verrengia\Desktop\EsempioFileWatcher\ProvaWriter.txt");
            writer.WriteLine($"Scrivo nuove informazioni su file");
            writer.Close();
        }
    }
}
