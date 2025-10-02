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

namespace _11___CalculadoraChurras
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

        double totalGeral = 0;

        private void txtQuantidade1_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Verifica se há algum valor digitado
            tblSubtotal1.Text = txtQuantidade1.Text != ""

            //Se tiver calcula e mostra com R$
            ? "R$ " + (Convert.ToDouble(txtQuantidade1.Text) * 34.90).ToString("F2")
            //Se não tiver mostra "R$ 0,00"
            : "R$ 0,00";
        }
        private void txtQuantidade2_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblSubtotal2.Text = txtQuantidade2.Text != ""
            ? "R$ " + (Convert.ToDouble(txtQuantidade2.Text) * 46).ToString("F2")
            : "R$ 0,00";
        }

        private void txtQuantidade3_TextChanged(object sender, TextChangedEventArgs e)
        {

            tblSubtotal3.Text = txtQuantidade3.Text != ""
            ? "R$ " + (Convert.ToDouble(txtQuantidade3.Text) * 17.99).ToString("F2")
            : "R$ 0,00";
        }

        private void txtQuantidade4_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblSubtotal4.Text = txtQuantidade4.Text != ""
            ? "R$ " + (Convert.ToDouble(txtQuantidade4.Text) * 29).ToString("F2")
            : "R$ 0,00";
        }

        private void txtQuantidade5_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblSubtotal5.Text = txtQuantidade5.Text != ""
            ? "R$ " + (Convert.ToDouble(txtQuantidade5.Text) * 49)
            : "R$ 0,00";
        }
        private void btnProximo_Click(object sender, RoutedEventArgs e)
        {
            tabChurras.SelectedIndex = 1; // Ir para aba dos acessórios
        }

        private void chkCarvao_Click(object sender, RoutedEventArgs e)
        {
            double valor = chkCarvao.IsChecked == true
            ? 24.90 : 0;

            tblSubtotalAc1.Text = "R$ " + valor.ToString("F2");
        }

        private void chkPratos_Click(object sender, RoutedEventArgs e)
        {
            double valor = chkPratos.IsChecked == true ? 9.90 : 0;
            tblSubtotalAc2.Text = "R$ " + valor.ToString("F2");
        }

        private void chkTalheres_Click(object sender, RoutedEventArgs e)
        {
            double valor = chkTalheres.IsChecked == true ? 4.90 : 0;
            tblSubtotalAc3.Text = "R$ " + valor.ToString("F2");
        }

        private void chkFacas_Click(object sender, RoutedEventArgs e)
        {
            double valor = chkFacas.IsChecked == true ? 4.90 : 0;
            tblSubtotalAc4.Text = "R$ " + valor.ToString("F2");
        }

        private void chkCopos_Click(object sender, RoutedEventArgs e)
        {
            double valor = chkCopos.IsChecked == true ? 7.50 : 0;
            tblSubtotalAc5.Text = "R$ " + valor.ToString("F2");
        }

        private void btnProximo2_Click(object sender, RoutedEventArgs e)
        {
            tabChurras.SelectedIndex = 2;
        }

        private void btnFinalizar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            (string.IsNullOrWhiteSpace(cmbEntrega.Text) || string.IsNullOrWhiteSpace(cmbPagamento.Text)) ?
            "Selecione a entrega e o pagamento!" :
            $"Pedido finalizado!\n\nTotal: R$ {totalGeral:F2}\nEntrega: {cmbEntrega.Text}\nPagamento: {cmbPagamento.Text}",
            "Resumo", MessageBoxButton.OK,
            MessageBoxImage.Information
            );
        }

        private void btnAnterior_Click(object sender, RoutedEventArgs e)
        {
            tabChurras.SelectedIndex = 0;
        }

        private void btnAnterior_Copiar_Click(object sender, RoutedEventArgs e)
        {
            tabChurras.SelectedIndex = 1;
        }

        private void tabChurras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabChurras.SelectedIndex == 2) // Aba total
            {
                double totalCarnes =
                    (tblSubtotal1.Text != "R$ 0,00" ? Convert.ToDouble(tblSubtotal1.Text.Replace("R$", "")) : 0) +
                    (tblSubtotal2.Text != "R$ 0,00" ? Convert.ToDouble(tblSubtotal2.Text.Replace("R$", "")) : 0) +
                    (tblSubtotal3.Text != "R$ 0,00" ? Convert.ToDouble(tblSubtotal3.Text.Replace("R$", "")) : 0) +
                    (tblSubtotal4.Text != "R$ 0,00" ? Convert.ToDouble(tblSubtotal4.Text.Replace("R$", "")) : 0) +
                    (tblSubtotal5.Text != "R$ 0,00" ? Convert.ToDouble(tblSubtotal5.Text.Replace("R$", "")) : 0);

                double totalAcessorios =
                    (tblSubtotalAc1.Text != "R$ 0,00" ? double.Parse(tblSubtotalAc1.Text.Replace("R$", "")) : 0) +
                    (tblSubtotalAc2.Text != "R$ 0,00" ? double.Parse(tblSubtotalAc2.Text.Replace("R$", "")) : 0) +
                    (tblSubtotalAc3.Text != "R$ 0,00" ? double.Parse(tblSubtotalAc3.Text.Replace("R$", "")) : 0) +
                    (tblSubtotalAc4.Text != "R$ 0,00" ? double.Parse(tblSubtotalAc4.Text.Replace("R$", "")) : 0) +
                    (tblSubtotalAc5.Text != "R$ 0,00" ? double.Parse(tblSubtotalAc5.Text.Replace("R$", "")) : 0);

                double totalGeral = totalCarnes + totalAcessorios;

                tblValorTotal.Text = $"Total: R$ {totalGeral:F2}";
            }
        }
    }
}