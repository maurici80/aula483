using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParametros
{
    class teste
    {

        public int Acrescentar(int  x, int v = 10)
        {
            v = v + x;
            return v;
        }
        public void Diminuir(ref int valor)
        {
            valor -= 5;
        }
    }
}

/* primeira implementacao
        public void Acrescentar(ref int valor)
        {
            valor += 5;
        }
        public void Diminuir(ref int valor)
        {
            valor -= 5;
        }
*/