using System.Diagnostics.Eventing.Reader;
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

namespace _06___CalculadoraDeGorjeta
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double comanda = Convert.ToDouble(txtValorNota.Text);
            double porcentagem = 0;

            if (cmbAcrescimo.SelectedIndex == 0)
                porcentagem = 0.05;
            else if (cmbAcrescimo.SelectedIndex == 1)
                porcentagem = 0.10;
            else if (cmbAcrescimo.SelectedIndex == 2)
                porcentagem = 0.15;
            else if (cmbAcrescimo.SelectedIndex == 3)
                porcentagem = 0.20;

            double gorjeta = comanda * porcentagem;
            double total = comanda + gorjeta;

            lblValorComanda.Content = $"{comanda:C2}";
            lblValorGorjeta.Content = $"{gorjeta:C2}";
            lblValorTotal.Content = $"{total.ToString("C2")}";
        }
    }
}