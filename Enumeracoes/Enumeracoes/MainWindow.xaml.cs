using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Enumeracoes
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        teste objeto = new teste();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine("Esta frase vai aparecer no console");
            //teste objeto = new teste();
            objeto.ApresentarDia(teste.DiasDaSemana.sábado);
            objeto.Mover(teste.Movimentos.Direita);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            objeto.Mover(teste.Movimentos.Cima);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            objeto.Mover(teste.Movimentos.Esquerda);
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            objeto.Mover(teste.Movimentos.Baixo);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            objeto.Mover(teste.Movimentos.Direita);
        }
    }
}
