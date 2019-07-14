using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Windows.Threading;

namespace ValidandoWebSite
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

        List<ListaRequisicoes> list = new List<ListaRequisicoes>();

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            var listaDeSite = tbxUrl.Text.Split(',');

            foreach (var item in listaDeSite)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    try
                    { //cria uma requisicao dentro do nosso click do botao, igual a um navegador faz quando digitamos um url
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(item);
                        //Espera trazer os arquivos da numem "headers" indicand i status cod do site
                        HttpWebResponse response = await Task<WebResponse>.Factory.FromAsync(
                            request.BeginGetResponse,
                            request.EndGetResponse,
                            request) as HttpWebResponse;
                        //adiciona na nossa lista as informações
                        list.Add(new ListaRequisicoes()
                        {
                            Url = item,
                            Status = response.StatusCode.ToString()

                        });

                    }
                    catch (Exception err)
                    {
                        //MessageBox.Show(err.Message);
                        list.Add(new ListaRequisicoes()
                        {
                            Url = item,
                            Status = "Erro"
                        });
                    }

                }
            }
        }

        public class ListaRequisicoes
        {

            
            // url do site que queremos verificar se esta online
            public string Url { get; set; } = string.Empty;
            // retorna o status do codigo de retorno do site se esta ok ou deu erro
            public string Status { get; set; } = string.Empty;


        }
        //Criamos um timer global para executar um metodo em conjunto com a thread principal.
        DispatcherTimer timer = new DispatcherTimer();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //Setamos o evento Tick do timer que é executado em um temo determinado evendo que contem nossas operacoes
            timer.Tick += new EventHandler(timer_tick);
            //aqui definimos o ciclo de operacoes que nosso timer irá fazer em um loop ate que eu fale que ele deva parar
            // ou a aplicacao seja finalizada
            timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            //aqui neste ponto indico que o timer ja pode executar com a thread principal
            timer.Start();

            //Task.Run(() => {
            //    while (true)
            //    {
            //        tbxStatusReport.Clear();
            //        foreach (ListaRequisicoes item in list)
            //        {
            //            tbxStatusReport.AppendText($"Url: {item.Url} \r\nStatusCode:{item.Status}");
            //        }
            ////    }
            //});

        }

        private void timer_tick(object sender, EventArgs e)
        {
            //Aqui eu limpo tofa ver que ele entrar no meu metodo o que ja foi escrito na area de texto
            tbxStatusReport.Clear();
            //Percorro minha lista de sites ja adicionados para mostrar
            foreach (ListaRequisicoes item in list)
            {//Apresento as informacões de forma formatada
                tbxStatusReport.AppendText($"\r\nUrl: {item.Url} \r\nStatusCode:{item.Status}");
            }


        }

    }
}
