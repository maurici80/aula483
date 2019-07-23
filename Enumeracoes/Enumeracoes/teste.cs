using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes
{
    class teste
    {
        public enum DiasDaSemana
        {
            domingo, segunda, terça, quarta, quinta, sexta, sábado

        }

        public enum Movimentos { Cima, Baixo, Esquerda, Direita}
        public void ApresentarDia(DiasDaSemana dia)
        {
            Console.WriteLine("O dia escolhido foi "+ dia);
        }

        public void Mover(Movimentos direcao)
        {
            Console.WriteLine("O jogador moveu-se para " + direcao);
        }
    }
}
