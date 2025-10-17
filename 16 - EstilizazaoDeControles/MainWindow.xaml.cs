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

namespace _16___EstilizazaoDeControles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GerarLabelProg();
            GerarLabelEstilo();
        }

        private void GerarLabelEstilo()
        {
            List<string> list = new List<string> { "Sarah", "Ana", "Guilerme", "Rafa", "Maria", "Milly", "Alex", "Gustavo", "Luis" };

            List<string> listColors = new List<string> { "#FFF9A8F4", "#FFE9F1AE", "#FFB7F399", "#FFA5AEFF", "#FFFFA09D", "#FFBEF8FF", "#FFFFCA75", "#FF8AFFA2", "#FF908FFF" };

            int index = 0;

            foreach (string item in list)
            {
                // Cria uma Label de forma programática
                Label label = new Label();
                label.Content = item;

                wrpEstilo.Children.Add(label);

                index++;
            }
        }


        private void GerarLabelProg()
        {
            List<string> list = new List<string> { "Sarah", "Ana", "Guilerme", "Rafa", "Maria", "Milly", "Alex", "Gustavo", "Luis" };

            List<string> listColors = new List<string> { "#FFF9A8F4", "#FFE9F1AE", "#FFB7F399", "#FFA5AEFF", "#FFFFA09D", "#FFBEF8FF", "#FFFFCA75", "#FF8AFFA2", "#FF908FFF" };

            int index = 0;

            foreach (string item in list)
            {
                // Cria uma Label de forma programática
                Label label = new Label();
                label.Content = item;
                label.Height = 100;
                label.Width = 100;
                label.FontSize = 12;
                label.VerticalContentAlignment = VerticalAlignment.Center;
                label.HorizontalContentAlignment = HorizontalAlignment.Center;
                label.FontWeight = FontWeights.Regular;

                // Aplica cor Hexadecimal
                Color corDeFundo = (Color)ColorConverter.ConvertFromString(listColors[index]);
                label.Background = new SolidColorBrush(corDeFundo);

                // Aplica cor "Simples"
                label.Foreground = new SolidColorBrush(Colors.Black);

                // Adiciona as Labels dentro do WrapPanel
                wrpFrog.Children.Add(label);

                index++;
            }
        }
    }
}