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

namespace ClassesParametros
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            teste objeto = new teste();

            int v = 10;

            v = objeto.Acrescentar(300);

            textBox.Text = v.ToString();
        }
    }
}
/*primeira implentacao
         private void Button_Click(object sender, RoutedEventArgs e)
        {
            teste objeto = new teste();

            int v = 10;

            objeto.Acrescentar(ref v);
            textBox.Text = v.ToString();
        }
*/