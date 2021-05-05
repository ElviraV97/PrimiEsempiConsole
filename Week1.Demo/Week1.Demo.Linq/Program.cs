
using System;
using System.Collections.Generic;
using System.Linq;

namespace Week1.Demo.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Valutazione> voti = Program.CaricaValutazioni();
            // recupero tutti i voti di Francesca
            // lambda expression
            var votiFrancesca = voti.Where(votazione => votazione.NomeStudente.Equals("Francesca"));
            // equivalente a 
            // query syntax o fluent api
            var votiFrancescaFluentApi =
                from valutazione in voti
                where valutazione.NomeStudente.Equals("Francesca")
                select valutazione;

            foreach(Valutazione valutazione in votiFrancesca)
            {
                Console.WriteLine($"Nome: {valutazione.NomeStudente} " +
                    $"Data: {valutazione.DataValutazione.ToShortDateString()}" +
                    $"Voto: {valutazione.Voto}" +
                    $"Materia: {valutazione.Materia}");
            }

            Console.WriteLine("---------");

            foreach (Valutazione valutazione in votiFrancescaFluentApi)
            {
                Console.WriteLine($"Nome: {valutazione.NomeStudente}" +
                    $"Data: {valutazione.DataValutazione.ToShortDateString()}" +
                    $"Voto: {valutazione.Voto}" +
                    $"Materia: {valutazione.Materia}");
            }

            // lambda expression
            var votiMatematicaOrdinati = voti
                                        .Where(v => v.Materia == Materia.Matematica)
                                        .OrderBy(voti => v.DataValutazione)
                                        .ThenBy(v => v.Voto);

            // equivalente a 
            var votiMatematicaOrdinatiFA =
                from voto in voti
                where voto.Materia == Materia.Matematica
                orderby voto.DataValutazione
                select voto;

            foreach(Valutazione valutazione in votiMatematicaOrdinati)
            {
                Console.WriteLine(valutazione.NomeStudente + " " 
                    + valutazione.DataValutazione.ToShortDateString() + " " + valutazione.Materia);
            }

            foreach(var val in votiMatematicaOrdinatiFA)
            {
                Console.WriteLine(val.NomeStudente + " "
                    + val.DataValutazione.ToShortDateString() + " " + val.Materia);
            }

            //lambda expression
            var soloVoti = voti
                .Where(v => v.NomeStudente.Equals("Mario"))
                .Select(v => new { v.Voto });
            //equivalente a
            //fluent api
            var soloVotiFA =
                from voto in voti
                where voto.NomeStudente.Equals("Mario")
                select new { voto.Voto };

            foreach (Valutazione voto in soloVoti)
            {
                Console.WriteLine(voto.Voto);
            }
            foreach (var voto in soloVotiFA)
            {
                Console.WriteLine(voto.Voto);
            }

            //Media voti per ogni studente
            // lambda exp
            var mediaVotiStudente = voti
                .GroupBy(
                v => v.NomeStudente, //la proprietà su cui raggruppare
                (key, grp) => new
                {
                    Nome = key,
                    Media = grp.Average(v => v.Voto),
                    Max = grp.Max(v => v.Voto),
                    Min = grp.Min(v => v.Voto)
                });

            //equivalente a 
            var mediaMAxMinStudenteFA =
                from voto in voti
                group voto by voto.NomeStudente into grp
                select new
                {
                    Nome = grp.Key,
                    Media = grp.Average(v => v.Voto),
                    Max = grp.Max(v => v.Voto),
                    Min = grp.Min(v => v.Voto)
                };

            Console.WriteLine("Stampa media, massimo, minimo dei voti per ogni studente");
            foreach(var gruppo in mediaVotiStudente)
            {
                Console.WriteLine($"Nome: {gruppo.Nome} - " +
                    $"Media Voti: {gruppo.Media} - " +
                    $"Voto massimo{gruppo.Max} - " +
                    $"Voto minimo: {gruppo.Min}");
            }
        }
        
        public static List<Valutazione> CaricaValutazioni
        {
            List<Valutazione> valutazioni = new List<Valutazione>(){

        }
    }
}
