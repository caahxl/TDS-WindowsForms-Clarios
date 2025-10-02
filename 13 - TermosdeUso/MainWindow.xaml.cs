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

namespace _13___TermosdeUso
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtTexto.Text = """
                Licença MIT

                Direitos autorais (c) Microsoft Corporation. Todos os direitos reservados.

                Concede-se, por meio deste, permissão, gratuita, a qualquer pessoa que obtenha uma cópia deste software e dos arquivos de documentação associados (o "Software"), para lidar com o Software sem restrições, incluindo, entre outras, os direitos de usar, copiar, modificar, mesclar, publicar, distribuir, sublicenciar e/ou vender cópias do Software, e para permitir que as pessoas a quem o Software é fornecido o façam, sujeito às seguintes condições:
                O aviso de direitos autorais acima e este aviso de permissão deverão ser incluídos em todas as cópias ou partes substanciais do Software.

                O SOFTWARE É FORNECIDO "NO ESTADO EM QUE SE ENCONTRA", SEM GARANTIA DE QUALQUER TIPO, EXPRESSA OU IMPLÍCITA, INCLUINDO, MAS NÃO SE LIMITANDO ÀS GARANTIAS DE COMERCIALIZAÇÃO, ADEQUAÇÃO A UM PROPÓSITO ESPECÍFICO E NÃO VIOLAÇÃO. EM NENHUMA HIPÓTESE OS AUTORES OU TITULARES DOS DIREITOS AUTORAIS SERÃO RESPONSÁVEIS POR QUALQUER RECLAMAÇÃO, DANOS OU OUTRA RESPONSABILIDADE, SEJA EM UMA AÇÃO CONTRATUAL, ATO ILÍCITO OU DE OUTRA FORMA, DECORRENTE DE, DE OU EM CONEXÃO COM O SOFTWARE OU O USO OU OUTRAS NEGOCIAÇÕES NO SOFTWARE
                """;
        }

        private void chkTermo_Click(object sender, RoutedEventArgs e)
        {
            if (chkTermo.IsChecked == true)
            {
                btnInstalar.IsEnabled = true;
            }

            else
            {
                btnInstalar.IsEnabled = false;
            }
        }

        private void btnInstalar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A instalação do Software foi iniciada...",
                "Aguarde a instalação ser concluída",
                MessageBoxButton.OK,
                MessageBoxImage.Exclamation
            );

            MessageBox.Show("Instalação CONCLUÍDA!",
               "Aguarde a instalação ser concluída",
               MessageBoxButton.OK,
               MessageBoxImage.Information
            );
        }

        private void chkTermo_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}