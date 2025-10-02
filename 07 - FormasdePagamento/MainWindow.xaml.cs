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

namespace _07___FormasdePagamento
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

        private void btnCalcular_Click_1(object sender, RoutedEventArgs e)
        {
            string valor = txtValor.Text;
            double valorPag = double.Parse(valor);


            lblValorPix.Content = $"{valorPag - (valorPag * 0.05):C2}";

            lblValorDebito.Content = $"{valorPag:C2}";

            lblValorCredito1.Content = $"{valorPag:C2}";

            lblValorCredito2.Content = $"{(valorPag + (valorPag * 0.025)) / 2:C2}";

            lblValorCredito3.Content = $"{(valorPag + (valorPag * 0.05)) / 3:C2}";
        }
    }
}