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

namespace _19___HoroscopoChines
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

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtAno.Text, out int ano))
            {
                MessageBox.Show("Digite um ano válido!");
                return;
            }

            string[] signos = { "rato", "boi", "tigre", "coelho", "dragao", "cobra", 
                "cavalo", "carneiro", "macaco", "galo", "cachorro", "javali"};

            int indice = (ano - 1900) % 12;
            indice = indice < 0 ? indice + 12 : indice; // Garante que o índice seja positivo

            string signo = signos[indice];
            tblSigno.Text = $"Seu signo é: {signo}";

            // Caminho da imagem 
            imgSigno.Source = new BitmapImage(new Uri($"/Imagens/{signo}.png", UriKind.Relative));

        }
    }
}