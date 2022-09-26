using System;
using System.Threading;

namespace Paralelismo.ConsoleApp
{
    internal class ClasseMetodosSincronos
    {
        public ClasseMetodosSincronos()
        {
        }

        public string MetodoQueDemora_1_Segundo()
        {
            Thread.Sleep(1000);
            return "Este processo levou 1 segundo";
        }

        public string MetodoQueDemora_2_Segundos()
        {
            Thread.Sleep(2000);
            return "Este processo levou 2 segundos";
        }

        public string MetodoQueDemora_3_Segundos()
        {
            Thread.Sleep(3000);
            return "Este processo levou 3 segundos";
        }
    }
}