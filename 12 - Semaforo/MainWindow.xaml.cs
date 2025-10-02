using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _12___Semaforo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rdbDesligado_Checked(object sender, RoutedEventArgs e)

        {
            //Caminho Absoluto(Começa da pasta raiz do sistema):
            //C:\Users\Aluno\source\repos\TDS_WindowsForms\12 - Semaforo\imagens\desligado.png

            //Caminho Relativo (Começa na pasta raiz do projeto):
            //Imagens/desligado.png
            imgSemafaro.Source = new BitmapImage(new Uri("/imagens/desligado.png", UriKind.Relative));
        }

        private void rdbVermelho_Checked(object sender, RoutedEventArgs e)
        {
            imgSemafaro.Source = new BitmapImage(new Uri("/imagens/vermelho.png", UriKind.Relative));
        }

        private void rdbAmarelo_Checked(object sender, RoutedEventArgs e)
        {
            imgSemafaro.Source = new BitmapImage(new Uri("/imagens/amarelo.png", UriKind.Relative));
        }

        private void rdbVerde_Checked(object sender, RoutedEventArgs e)
        {
            imgSemafaro.Source = new BitmapImage(new Uri("/imagens/verde.png", UriKind.Relative));
        }

        private void Troca_Imagem(object sender, RoutedEventArgs e)
        {
           RadioButton radio = sender as RadioButton;

            string nome = radio.Name;

            switch(nome)
            {
                case "rdbDesligado":
                    imgSemafaro.Source = new BitmapImage(new Uri("/imagens/desligado.png", UriKind.Relative));
                    break;

                case "rdbVermelho":
                    imgSemafaro.Source = new BitmapImage(new Uri("/imagens/vermelho.png", UriKind.Relative));
                    break;

                case "rdbAmarelo":
                    imgSemafaro.Source = new BitmapImage(new Uri("/imagens/amarelo.png", UriKind.Relative));
                    break;

                case "rdbVerde":
                    imgSemafaro.Source = new BitmapImage(new Uri("/imagens/verde.png", UriKind.Relative));
                    break;
            }
        }
    }
}