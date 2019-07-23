using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConstrutorOverloading
{
    class teste
    {

        string _nome;
        int _idade;

        //construtor
        public teste (string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        public void Apresentar()
        {
            MessageBox.Show(_nome + " -> " + _idade);
        }
        public void Apresentar(string separador)
        {
            MessageBox.Show(_nome + separador + _idade);
        }
        public void Apresentar(int idade)
        {
            MessageBox.Show(_nome + " .. " + + idade);
        }


    }
}
