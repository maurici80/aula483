using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaComParallel
{
    class Program
    {
        static List<ParallelListTeste> listaDeitens = new List<ParallelListTeste>();


        static void Main(string[] args)
        {
            var iniciDaoperacao = DateTime.Now;
            CarregaListaParalela(); ///
            var tempoTotal = DateTime.Now - iniciDaoperacao;

            Console.WriteLine($"Tempo total para executar a operação: {tempoTotal}");
            Console.ReadKey();

        }

        public static void CarregaListaParalela()
        {
            Parallel.For(0, 62000, i =>
            {
                listaDeitens.Add(new ParallelListTeste()
                {
                    Numero = i
                });
            });

        }

        public static void CarregaLista()
        {
            for (int i = 0; i < 1000; i++)
            {
                listaDeitens.Add(new ParallelListTeste()
                {
                    Numero = i

                });

            }
        }



        public class ParallelListTeste
        {
            //Número que indica a ordem de criação deste item;
            public int Numero { get; set; } = 0;


            //Indicador booleano que mostra se foi atualizado ou não.
            public bool Atualizado { get; set; } = false;


        }
    }
}
