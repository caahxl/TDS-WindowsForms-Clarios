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

namespace _15___CriancaoDeComponentes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Criando RadioButton programticamente

            RadioButton rdbComida1 = new RadioButton();
            rdbComida1.Content = "Pizza";
            rdbComida1.VerticalContentAlignment = VerticalAlignment.Center;
            rdbComida1.Checked += EscolherComida;

            RadioButton rdbComida2 = new RadioButton();
            rdbComida2.Content = "Batata Frita";
            rdbComida2.VerticalContentAlignment = VerticalAlignment.Center;
            rdbComida2.Checked += EscolherComida;

            RadioButton rdbComida3 = new RadioButton();
            rdbComida3.Content = "Strogonoff";
            rdbComida3.VerticalContentAlignment = VerticalAlignment.Center;
            rdbComida3.Checked += EscolherComida;

            RadioButton rdbComida4 = new RadioButton();
            rdbComida4.Content = "Fricasse";
            rdbComida4.VerticalContentAlignment = VerticalAlignment.Center;
            rdbComida4.Checked += EscolherComida;

            RadioButton rdbComida5 = new RadioButton();
            rdbComida5.Content = "Vinagrete";
            rdbComida5.VerticalContentAlignment = VerticalAlignment.Center;
            rdbComida5.Checked += EscolherComida;


            // Adiciona os radiobutton dentro do stackpainel
            stkComida.Children.Add(rdbComida1);
            stkComida.Children.Add(rdbComida2);
            stkComida.Children.Add(rdbComida3);
            stkComida.Children.Add(rdbComida4);
            stkComida.Children.Add(rdbComida5);
        }

        private void EscolherComida(object sender, RoutedEventArgs e)
        {
            RadioButton radio = (RadioButton)sender;

            string? conteudo = radio.Content.ToString();

            tblComida.Text = conteudo;
        }

        private void escolherBebida(object sender, RoutedEventArgs e)
        {
            //RadioButton radio = sender as RadioButton;
            RadioButton radio = (RadioButton)sender;

            string? conteudo = radio.Content.ToString();

            switch (conteudo)
            {
                case "Café":
                    tblBebidaManual.Text = "Café";
                    break;
                case "Chá":
                    tblBebidaManual.Text = "Chá";
                    break;
                case "Suco":
                    tblBebidaManual.Text = "Suco";
                    break;
                case "Água":
                    tblBebidaManual.Text = "Água";
                    break;
                case "Refrigerante":
                    tblBebidaManual.Text = "Refrigerante";
                    break;
            }

            tblBebidaManual.Text = "Café";
        }

        /* private void rdbCafeManual_Checked(object sender, RoutedEventArgs e)
        {
            tblBebidaManual.Text = "Café";
        }

        private void rdbChaManual_Checked(object sender, RoutedEventArgs e)
        {

            tblBebidaManual.Text = "Chá";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            tblBebidaManual.Text = "Suco";
        }

        private void rdbAguaManual_Checked(object sender, RoutedEventArgs e)
        {

            tblBebidaManual.Text = "Água";
        }

        private void rdbRefriManual_Checked(object sender, RoutedEventArgs e)
        {

            tblBebidaManual.Text = "Refrigerante";
        }*/
    }
}