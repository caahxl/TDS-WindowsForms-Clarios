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

namespace _08___CalculadoraSimples
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

        string operacao = "";
        double valorArmazenado = 0;

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if (txtResultado.Text == "")
                return;

            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text += "3";
        }
        private void btnQuatro_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text += "4";
        }
        private void btnCinco_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text += "5";
        }
        private void btnSeis_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text += "6";
        }
        private void btnSete_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnApagar_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = "";
            operacao = "";
            valorArmazenado = 0;
        }

        private void btnDivisao_Click(object sender, RoutedEventArgs e)
        {

            operacao = "/";
            valorArmazenado = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            operacao = "*";
            valorArmazenado = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnSubtracao_Click(object sender, RoutedEventArgs e)
        {
            operacao = "-";
            valorArmazenado = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnSoma_Click(object sender, RoutedEventArgs e)
        {
            operacao = "+";
            valorArmazenado = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            //Verificar se uma operação foi selecionda
            if (operacao == "" || txtResultado.Text == "")
                return;

            double valorAtual = Convert.ToDouble(txtResultado.Text);
            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = valorArmazenado + valorAtual;
                    break;

                case "-":
                    resultado = valorArmazenado - valorAtual;
                    break;

                case "*":
                    resultado = valorArmazenado * valorAtual;
                    break;

                case "/":
                    resultado = valorArmazenado / valorAtual;
                    break;
            }
            //Exibe o resultado no display e reseta a operação
            txtResultado.Text = resultado.ToString();
            operacao = "";
        }

        private void btnSeta_Click(object sender, RoutedEventArgs e)
        {
            string valorAtual = txtResultado.Text;

            int numCaracteres = valorAtual.Length;

            //Verifica se há valor no display
            if (numCaracteres == 0)
                return;

            string novoValor = valorAtual.Remove(numCaracteres - 1);

            txtResultado.Text = novoValor;

            //Outro Modo de Fazer:
            //if (txtResultado.Text.Length > 0)
            //{
            //    txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
            //}
        }

        private void btnPonto_Click(object sender, RoutedEventArgs e)
        {
            bool temVirgula = txtResultado.Text.Contains(",");

            if (temVirgula)
                return;

            else if (txtResultado.Text == "")
            txtResultado.Text += "0,";

            else
                txtResultado.Text += ",";
        }

        private void btnApagarCE_Click(object sender, RoutedEventArgs e)
        {
            //Verifica se há alguma vírgula
            txtResultado.Text = "";
            operacao = "";
            valorArmazenado = 0;
        }
    }
}