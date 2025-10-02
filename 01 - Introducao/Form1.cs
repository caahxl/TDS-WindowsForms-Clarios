namespace _01___Introducao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entrada = textEntrada.Text;
            lblPalavra.Text = entrada;
        }

        private void btnTela2_Click(object sender, EventArgs e)
        {
            Form  frmNumero = new frmNumero();
            
            //Abre uma nova tela deixando a primeira livre
            //frmNumero.Show();

            //Abre uma nova tela deixando a primeira travada
            frmNumero.ShowDialog();
        }
    }
}
