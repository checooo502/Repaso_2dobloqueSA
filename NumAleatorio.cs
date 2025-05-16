using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_2dobloqueSA
{
    public partial class NumAleatorio : Form
    {
        int aleatorio = 0;
        Random rand = new Random();
        public NumAleatorio()
        {
            InitializeComponent();
        }

        private void NumAleatorio_Load(object sender, EventArgs e)
        {

        }

        private void txtNumMax_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Button.Text, out int numMax))
            {
                aleatorio = rand.Next(1, numMax);
                MessageBox.Show($"numero; {aleatorio}");
            }
            else
            {
                MessageBox.Show("ingrese un numero valido");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
