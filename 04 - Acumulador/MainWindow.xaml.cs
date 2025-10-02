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

namespace _04___Acumulador
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

        private void btnIncrementar_Click(object sender, RoutedEventArgs e)
        {
            int contador = Convert.ToInt32(lblContador.Content);
            int multiplicar = Convert.ToInt32(txtAlterar.Text);
            contador = contador + multiplicar;
            lblContador.Content = contador;
        }

        private void btnIncrementar_Copiar1_Click(object sender, RoutedEventArgs e)
        {
            int contador = Convert.ToInt32(lblContador.Content);
            int multiplicar = Convert.ToInt32(txtAlterar.Text);
            contador = contador - multiplicar;
            lblContador.Content = contador;
        }

        private void lblZerar_Click(object sender, RoutedEventArgs e)
        {
            int contador = Convert.ToInt32(lblContador.Content);
            contador = 0;
            lblContador.Content = contador;
        }
    }
}