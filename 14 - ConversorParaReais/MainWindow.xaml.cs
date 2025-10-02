using System.Globalization;
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

namespace _14___ConversorParaReais
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbMoedas.SelectedIndex = 0;
        }

        private void cmbMoedas_DropDownClosed(object sender, EventArgs e)
        {
            string moeda = cmbMoedas.Text;

            switch (moeda)
            {
                case "Dólar Americano":
                    imagensPaises.Source = new BitmapImage(new Uri("Imagens/EUA.png", UriKind.Relative));
                    break;
                case "Euro":
                    imagensPaises.Source = new BitmapImage(new Uri("Imagens/Euro.png", UriKind.Relative));
                    break;
                case "Yuan Chinês":
                    imagensPaises.Source = new BitmapImage(new Uri("Imagens/China.png", UriKind.Relative));
                    break;
                case "Iene Japonês":
                    imagensPaises.Source = new BitmapImage(new Uri("Imagens/Japao.png", UriKind.Relative));
                    break;
                case "Peso Mexicano":
                    imagensPaises.Source = new BitmapImage(new Uri("Imagens/Mexico.png", UriKind.Relative));
                    break;
            }

            scrEstrangeiro_ValueChanged(null, null);
        }

        private void scrEstrangeiro_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double valor = scrEstrangeiro.Value;
            string moeda = cmbMoedas.Text;
            double fator = 1.0;

            switch (moeda)
            {
                case "Dólar Americano":
                    fator = 5.99;
                    break;
                case "Euro":
                    fator = 6.33;
                    break;
                case "Yuan Chinês":
                    fator = 0.83;
                    break;
                case "Iene Japonês":
                    fator = 0.04;
                    break;
                case "Peso Mexicano":
                    fator = 0.30;
                    break;
            }

            double convertido = valor * fator;

            // Atualiza campos de texto com os valores
            txtValorEstrangeiro.Text = valor.ToString("F2");
            tblRealBr.Text = convertido.ToString("C2");
        }
    }
}