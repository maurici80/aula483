using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    public static class Estatica
    {
        public static string Nome;

        public static string NomePrograma = "Aplicação de teste";




        public static void ApresentarNome()
        {
            Console.WriteLine(Nome);
        }
    }
}
