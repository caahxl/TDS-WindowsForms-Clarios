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

namespace _10___Eventos
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

        private void btnClique_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Evento de clique disparado",
                "Mouse",
                MessageBoxButton.OK, 
                MessageBoxImage.Information 
                );
        }

        private void btnMouseEnter_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show(
                "Você saiu do botão",
                "Mouse",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void btnMouseLeave_MouseLeave(object sender, MouseEventArgs e)
        {
            MessageBox.Show(
               "Você saiu do botão",
               "Mouse",
               MessageBoxButton.OK,
               MessageBoxImage.Information);
        }

        private void btnMouseRight_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(
              "Botão direito pressionado",
              "Mouse",
              MessageBoxButton.OK,
              MessageBoxImage.Information);
        }

        private void btnDouble_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(
               "Você deu duplo clique",
               "Mouse",
               MessageBoxButton.OK,
               MessageBoxImage.Information);
        }

        private void btnMouseWheel_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            MessageBox.Show(
              "Você girou a rodinha do mouse",
              "Mouse",
              MessageBoxButton.OK,
              MessageBoxImage.Information);
        }

        private void rdbSegunda_Checked(object sender, RoutedEventArgs e)
        {
            tblDia.Text = "Segunda-Feira";
        }

        private void rdbTerca_Checked(object sender, RoutedEventArgs e)
        {
            tblDia.Text = "Terça-Feira";
        }

        private void rdbQuarta_Checked(object sender, RoutedEventArgs e)
        {
            tblDia.Text = "Quarta-Feira";
        }

        private void rdbQuinta_Checked(object sender, RoutedEventArgs e)
        {
            tblDia.Text = "Quinta-Feira";
        }

        private void rdbSexta_Checked(object sender, RoutedEventArgs e)
        {
            tblDia.Text = "Sexta-Feira";
        }

        private void RdbSexta_Checked(object sender, RoutedEventArgs e)
        {
            tblDia.Text = "Sexta-Feira";
        }

        //Contador checkbox
        int contador = 0;

        ///////////////////////////////////////////////////////////////////////

        /*
        1ª Forma [12X]
        private void chkCarne_Checked(object sender, RoutedEventArgs e)
        {
            contador++;
            tblNumeroItens.Text = contador.ToString();
        }

        private void chkCarne_Unchecked(object sender, RoutedEventArgs e)
        {
            contador--;
            tblNumeroItens.Text = contador.ToString();
        }
        */

        /////////////////////////////////////////////////////////////////////////

        /*
        2ª Forma meio efetiva (Refratorio) [6X]
        private void chkCarne_Click(object sender, RoutedEventArgs e)
        {
            if (chkCarne.IsChecked == true)
                contador++;
            else
                contador--;

            tblNumeroItens.Text = contador.ToString();
        }
        */

        /////////////////////////////////////////////////////////////////////////

        //3ª Forma mais efetiva (Refratoração)
        private void CheckChurras(object sender, RoutedEventArgs e)
        {
            // 1º) Criar um CheckBox
            // Sender - Controle que disparou o evento
            CheckBox checkBox = (CheckBox)sender;

            // 2º) Quando alterado o Checkbox incrementa ou decrementa
            if (checkBox.IsChecked == true)
                contador++;
            else
                contador--;

            tblNumeroItens.Text = contador.ToString();
        }
        ///////////////////////////////////////////////////////////////////////
        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Seja Bem-Vindo ao Sistema!",
                "Tela de Entrada",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }

        private void chkAtivo_Checked(object sender, RoutedEventArgs e)
        {
            if (chkAtivo.IsChecked == true)
                //Ativo o botão
                btnEntrar.IsEnabled = true;
            else
                btnEntrar.IsEnabled = false;
        }

        private void cmbTransporte_DropDownClosed(object sender, EventArgs e)
        {
            string valor = cmbTransporte.Text;

            tblResposta.Text = valor;
        }
    }
}