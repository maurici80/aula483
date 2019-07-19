using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CamposPropriedades
{
    class teste
    {
        //definicao de um CAMPO
        private string _nome;


        //difinicao de uma PROPRIEDADE
        public string Nome
        {
            set // difinir o valor de 'Nome' (Entrada)
            {
                if (value == "Maurici")
                {
                    MessageBox.Show("Aconteceu um erro!!");
                    _nome = "Nem pensar!";
                }
                else
                    _nome = value;

            }
            get // ir buscar o valor de '_nome' (Saída)
            {
                return _nome;
            }
        }
        public void Apresentar()
        {
            MessageBox.Show(_nome);
        }
    }
}
