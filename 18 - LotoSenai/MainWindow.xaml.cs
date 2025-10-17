using System.Diagnostics.CodeAnalysis;
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

namespace _18___LotoSenai
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
        List<string> NumerosSorteado = new List<string> { };
        List<string> numerosEscolhidos = new List<string> { };
        private void GerarNumerosSorteados()
        {

            // limpar a lista
            NumerosSorteado.Clear();

            // Random - Classe responsavel por gerar números aleatórios
            Random random = new Random();

            while (true)
            {
                // Verifica o tamanho da lista
                int tamanhoDaLista = NumerosSorteado.Count;

                if (tamanhoDaLista >= 5)
                    break;
                string NumeroAleatorio = random.Next(1, 21).ToString("00");

                // verifica se o valor sorteado não está contido na lista
                bool estaContido = !NumerosSorteado.Contains(NumeroAleatorio);

                if (estaContido)
                    NumerosSorteado.Add(NumeroAleatorio);
            }

            // Ordenar a lista de números
            NumerosSorteado.Sort();

            tblPrimeiro.Text = NumerosSorteado[0];
            tblSegundo.Text = NumerosSorteado[1];
            tblTerceiro.Text = NumerosSorteado[2];
            tblQuarto.Text = NumerosSorteado[3];
            tblQuinto.Text = NumerosSorteado[4];
        }

        private void NumerosEscolhidos()
        {
            numerosEscolhidos.Clear();

            numerosEscolhidos.Add(txtPrimeiro.Text.PadLeft(2, '0'));
            numerosEscolhidos.Add(txtSegundo.Text.PadLeft(2, '0'));
            numerosEscolhidos.Add(txtTerceiro.Text.PadLeft(2, '0'));
            numerosEscolhidos.Add(txtQuarto.Text.PadLeft(2, '0'));
            numerosEscolhidos.Add(txtQuinto.Text.PadLeft(2, '0'));
        }

        private bool ValidarEntrada()
        {
            string conteudo = "";
            bool isInvalido = false;

            foreach (string numero in numerosEscolhidos)
            {
                // Verifica se há alguns TextBox vazio
                if (numero == "00")
                {
                    isInvalido = true;
                    conteudo = "Preencha todos os campos antes de apostar!";
                    break;
                }

                bool temRepetido = numerosEscolhidos.Count(item => item.Equals(numero)) > 1;
                if (temRepetido)
                {
                    isInvalido = true;
                    conteudo = "Não insira números repetidos";
                    break;
                }

            }

            // Exibe uma mensagem de erro
            if (isInvalido)
            {
                MessageBox.Show(
                    conteudo,
                    "Aposta inválida",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
            }
            return isInvalido;

        }

        private void GerarImagens()
        {
            //Apaga todas as imagens (os filhos)
            wrpImagens.Children.Clear();


            //CARREGA UMA IMAGEM BACKGROUND
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Imagens/bola-verde.png"));

            for (int i = 1; i < 21; i++)
            {
                Label label = new Label();
                string conteudo = i.ToString("00");

                label.Content = conteudo;

                //Atualiza o background do número sorteado
                if (NumerosSorteado.Contains(conteudo))
                    label.Background = brush;

                wrpImagens.Children.Add(label);
            }
        }

        private void btnApostar_Click(object sender, RoutedEventArgs e)
        {


            NumerosEscolhidos();
            // Se houver entrada inválida para o evento
            if (ValidarEntrada())
                return;

            GerarNumerosSorteados();
            GerarImagens();

            // Contabiliza os números iguais das listas
            int contagemIgual = numerosEscolhidos.Count(
                elemento => NumerosSorteado.Contains(elemento)
            );

            string resultado = "";

            if (contagemIgual == 0)
                resultado = $"Você acertou nenhum numero! 🤡";
            else
                resultado = $"Você acertou {contagemIgual} numero(s) 😍";


            tblResultado.Text = resultado;
        }
    }
}