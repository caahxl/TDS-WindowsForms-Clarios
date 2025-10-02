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

namespace _05___MessageBox
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

        private void btnSimples1_Click(object sender, RoutedEventArgs e)
        {
            //1° Argumento: Conteúdo
            //2° Argumento: Argumento
            //3° Argumento: Botões
            //4° Argumento: ícones
            MessageBox.Show("Digite a sua msg", "Título");
        }

        private void btnSimples2_Click(object sender, RoutedEventArgs e)
        {
            //1° Argumento: Conteúdo
            //2° Argumento: Argumento
            //3° Argumento: Botões
            //4° Argumento: ícones
            MessageBox.Show("Conteúdo",
                "Título", MessageBoxButton.YesNo,
                MessageBoxImage.Asterisk);
        }

        private void btnIcones1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("xiii, deu ruim, chama o prof",
                "Menssagem de Erro",
                MessageBoxButton.OK,
                MessageBoxImage.Error
            );
        }

        private void btnIcones2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cuidado, isso pode causar problemas!",
               "Mensagem de Atenção",
               MessageBoxButton.OK,
               MessageBoxImage.Warning
            );
        }

        private void btnIcones3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tem certeza que deseja fazer isso?", 
                "Questão", 
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
        }

        private void btnIcones4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Alteração realizada!",
                "Informação",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void btnBotao1_Click(object sender, RoutedEventArgs e)
        {
            // Ok 
            MessageBox.Show("Aperte Ok",
                "Botões",
                MessageBoxButton.OK,
                MessageBoxImage.Asterisk);
        }

        private void btnBotao2_Click(object sender, RoutedEventArgs e)
        {
            // Ok ou Cancelar
            MessageBox.Show(
                "Aperte Ok ou Cancelar", 
                "Botões",
                MessageBoxButton.OKCancel, 
                MessageBoxImage.Asterisk
                );
        }

        private void btnBotao3_Click(object sender, RoutedEventArgs e)
        {
            // Sim ou Não
            MessageBox.Show(
               "Aperte Sim ou Não",
               "Botões",
               MessageBoxButton.YesNo,
               MessageBoxImage.Question
            );
        }

        private void btnBotao4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Deseja Cancelar, Não ou Continuar?",
                "Botões",
                MessageBoxButton.YesNoCancel,
                MessageBoxImage.Question
            );
        }

        private void btnPergunta1_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado =  MessageBox.Show(
                "Você realmente entendeu o MensagemBox? 🤔",
                "Aula de Hoje",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
            );

            if (resultado == MessageBoxResult.Yes)
                lblResposta.Content = "Parabéns, você é um ótimo aluno!";
            else
                lblResposta.Content = "Você não prestou atenção!";
        }

        private void btnEncerrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show(
                "Deseja encerrar a aplicação?",
                "Encerrar a aplicação",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning
            );
            //Shudown: Fecha a aplicação
            if (resultado == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }
    }
}