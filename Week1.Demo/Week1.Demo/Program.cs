using System;

namespace Week1.Demo
{
    class Program
    {
        // Dichiarazione delegate
        delegate int Somma(int a, int b);

        static void Main(string[] args)
        {
            Funzionalita.EsercizioTipo();   //Lo posso richiamare così perché è statico

            Somma somma = new Somma(Funzionalita.MiaSomma);

            int risultato = Funzionalita.MiaSomma(1, 2);


            Funzionalita.DemoEventi();
        }
    }
}
