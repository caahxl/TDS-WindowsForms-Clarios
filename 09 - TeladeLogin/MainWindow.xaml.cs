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

namespace _09___TeladeLogin
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

        int tentativas = 0;

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;

            // Evita erro se o usuário digitar letras na senha
            bool senhaValida = int.TryParse(pwdSenha.Password, out int senha);

            if (login == "admin" & senhaValida & senha == 1234)
            {
                MessageBox.Show(
                    "Seja bem-vindo(a) Admin!",
                    "Entrada Realizada com Sucesso!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                );
            }
            else
            {
                tentativas++;

                if (tentativas >= 3)
                {
                    MessageBox.Show(
                        "Usuário bloqueado após 3 tentativas...",
                        "Erro",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error
                    );

                    txtLogin.IsEnabled = false;
                    pwdSenha.IsEnabled = false;
                    btnEntrar.IsEnabled = false;
                }

                else
                {
                    MessageBox.Show(
                        "Falha ao entrar. Tente novamente.",
                        "Erro",
                        MessageBoxButton.OK,
                        MessageBoxImage.Exclamation
                    );
                }
            }
        }
    }
}