using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoThreads
{
    class Program
    {
        static void Main(string[] args)
        {

            //Classe do .net que trabalha com Threads paralelas com funcoes basicas de repeticao

            //Parallel.For(0, 100, i =>
            //{
            //    Console.WriteLine(i.ToString());

            //}); //faz o gerenciamento dos nucleos do processador 


            Parallel.For(0, 5, i =>
             {
                 ImprimeOCafeEstaPronto(i);
                 ImprimeOAlmocoEstaPronto(i);
             });

            /*
            Parallel.For(0, 5, i =>
            {

            });
            */

            Console.ReadKey();

        }

        public static void ImprimeOCafeEstaPronto(int numero)
        {
            Console.WriteLine($"O café Esta Pronto {numero}");

        }

        public static void ImprimeOAlmocoEstaPronto(int numero)
        {
            Console.WriteLine($"O almoco Esta Pronto {numero}");

        }
    }
}
