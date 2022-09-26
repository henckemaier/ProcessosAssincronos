using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Paralelismo.ConsoleApp
{
    internal class ClasseComMetodosAssincronos
    {
        internal class ClasseMetodosAssincronos
        {
        }

        public async Task<string> MetodoQueDemora_1_Segundo()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(1000);
                return "Este processo levou 1 segundo";
            });
        }

        public async Task<string> MetodoQueDemora_2_Segundos()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(2000);
                return "Este processo levou 2 segundos";
            });
        }

        public async Task<string> MetodoQueDemora_3_Segundos()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(3000);
                return "Este processo levou 3 segundos";
            });
        }
    }
}
