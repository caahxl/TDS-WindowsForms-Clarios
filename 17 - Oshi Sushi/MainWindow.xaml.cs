using System.Text;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _17___Oshi_Sushi
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

        double preco1 = 3.00;
        double preco2 = 28.00;
        double preco3 = 26.00;
        double preco4 = 25.00;
        double preco5 = 20.00;
        double preco6 = 23.00;
        double preco7 = 30.00;
        double preco8 = 30.00;

        private double CalcularSubtotal(TextBox caixa, double preco)
        {
            if (double.TryParse(caixa.Text, out double quantidade) && quantidade > 0)
            {
                return quantidade * preco;
            }

            return 0;
        }

        private void btnFecharConta_Click(object sender, RoutedEventArgs e)
        {
            // Array com todas as caixas de texto
            TextBox[] caixas = { txtSunomono, txtCarpaccioS, txtCarpaccioT, txtSashimiS, txtSashimiA, txtSashimiT, txtTeppanmakiC, txtTeppanmakiS };

            // Array com todos os preços
            double[] precos = { preco1, preco2, preco3, preco4, preco5, preco6, preco7, preco8 };

            double total = 0;

            for (int i = 0; i < caixas.Length; i++)
            {
                total += CalcularSubtotal(caixas[i], precos[i]);
            }

            MessageBox.Show(
                $"Total do pedido: R$ {total:F2}", 
                "Total", MessageBoxButton.OK, 
                MessageBoxImage.Information
            );
        }
    }
}
