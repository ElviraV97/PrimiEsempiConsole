using System;
using System.Threading.Tasks;

namespace Week1.Demo.Async_Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----For normale--------");
            Metodi.ForNormale();
            Console.WriteLine("-----------------");
            Console.WriteLine("--------- For parallelo -------");
            Metodi.ForParallelo();
            Console.WriteLine("------------------");

            // Metodi sincroni - esecuzione sequenziale
            Metodi.MetodoA();
            Metodi.MetodoB();
            Metodi.MetodoC();

            //Metodi asincroni - esecuzione non sequenziale
            Task taskA = Metodi.MetodoAAsync();
            Task taskB = Metodi.MetodoBAsync();
            Task taskC = Metodi.MetodoCAsync();

            Console.ReadKey();
        }
    }
}
