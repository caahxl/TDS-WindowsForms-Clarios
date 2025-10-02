using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01___Introducao
{
    public partial class frmNumero : Form
    {
        public frmNumero()
        {
            InitializeComponent();
        }

        private void bntSelecionar_Click(object sender, EventArgs e)
        {
            string numero = nudNumero.Value.ToString();
            lblDigite.Text = numero;
        }
    }
}
