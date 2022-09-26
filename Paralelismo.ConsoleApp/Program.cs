using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Paralelismo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch cronometro = new Stopwatch();

            var processoAssincrono = new ClasseComMetodosAssincronos();

            cronometro.Start(); //<--vai começar a cronometrar

            Task<string> umSegundo = processoAssincrono.MetodoQueDemora_1_Segundo();
            Task<string> doisSegundos = processoAssincrono.MetodoQueDemora_2_Segundos();
            Task<string> tresSegundos = processoAssincrono.MetodoQueDemora_3_Segundos();

            Console.WriteLine(umSegundo.Result);
            Console.WriteLine(doisSegundos.Result);
            Console.WriteLine(tresSegundos.Result);

            cronometro.Stop(); //<--para de cronometrar

            TimeSpan tempoGasto = cronometro.Elapsed; //<-- tempo gasto

            Console.WriteLine("Tempo gasto no processo síncrono: " + tempoGasto.ToString(@"m\:ss\.ffff"));

            Console.ReadLine();
        }
    }
}
