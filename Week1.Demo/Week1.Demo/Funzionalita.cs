using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Demo.Classi;
using Week1.Demo.Interfacce;
using Week1.Demo.Pub_Sub;

namespace Week1.Demo
{
    public class Funzionalita
    {

        public enum State
        {
            Open,
            New
        }

        public static void EsercizioTipo()
        {
            // Value type vs Reference type

            // Value type

            // Booleani
            bool x = true;
            bool y = false;

            bool z = !x;

            Console.WriteLine("Valore z: {0}", z);

            //Numerici
            int i = 0;
            int j = 34;

            int numero = 1 * (3 + 5) * 7;

            float f = 1f / 3f;
            double doubl = 1d / 3d;
            decimal dec = 1m / 3m;

            Console.WriteLine("Decimali: ");
            Console.WriteLine("f: {0}", f);
            Console.WriteLine("doubl: {0}", doubl);
            Console.WriteLine("dec: {0}", dec);

            Console.WriteLine("Float valore massimo{0}", float.MaxValue);

            DateTime now = DateTime.Now;
            DateTime tomorrow = now.AddDays(1);
            DateTime post5hours = now.AddHours(5);


            // Enum
            State mystate = State.Open;

            if (mystate == State.New)
            {
                Console.WriteLine("la mia variabile mystate contiene New");
            }
            else
            {
                Console.WriteLine($"La mia variabile mystate contiene {mystate}");
            }


            // Reference type
            //string
            string nome = "Antonia";
            nome = "giulia";

            Console.Clear();

            Persona p = new Persona {
                Nome = "Antonia",
                Cognome = "Sacchitella",
                DataNascita = new DateTime(1993, 3, 2)
            };
            
            Console.WriteLine(p.Eta);

            Manager m = new Manager
            {
                Nome = "Mario",
                Cognome = "Rossi",
                DataNascita = DateTime.Today
            };

            Console.WriteLine(m.Eta);
            Console.WriteLine(m.Stipendio);

            Persona m2 = new Manager { Nome = "Luca", Cognome = "Rossi", DataNascita = new DateTime(1970, 12, 3)};

            Console.WriteLine(m2.ToString());
            m2.CalcolaCodiceFiscale();

            IEntita m3 = new Manager();
            m3.CalcolaCodiceFiscale();
            
        }

        internal static int MiaSomma(int a, int b)
        {
            return a + b;
        }

        public static void DemoEventi()
        {
            //Publisher
            Publisher youtube = new Publisher("youtube.com");
            Publisher instagram = new Publisher("instagram");

            //Subscriber 
            Subscriber sub1 = new Subscriber("Mario");
            Subscriber sub2 = new Subscriber("Giulia");
            Subscriber sub3 = new Subscriber("Luana");

            sub1.Subscribe(youtube);
            sub3.Subscribe(youtube);

            sub2.Subscribe(instagram);

            youtube.Publish();
            Console.WriteLine("----------------------");

            instagram.Publish();

            sub1.Unsubscribe(youtube);

            
        }
    }
}
