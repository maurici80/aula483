using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadComEscolhadeQuantidade
{
    class Program
    {
        static List<ListaThread> listThreadload = new List<ListaThread>();
        static long indice = 0;

        static void Main(string[] args)
        {
            Thread t1 = new Thread(incrementIdex);
            t1.Start();

            Thread t2 = new Thread(incrementIdex);
            t2.Start();

            Thread t3 = new Thread(incrementIdex);
            t3.Start();

            var iniciou = DateTime.Now;


            while (indice < 1000000) { }

            var tempoTotal = DateTime.Now - iniciou;

            Console.WriteLine($"Tempo para execução: {tempoTotal}");
            Console.ReadKey();

        }

        public static void incrementIdex()
        {
            while (indice < 10000000)
                indice++;
        }

        public class ListaThread
        {
            //Número que define a ordem de criação
            public long Numero { get; set; } = 0;

            //Identificador booleano que mostra se foi atualizado
            public bool Atualizado { get; set; } = false;




        }
    }


}

    