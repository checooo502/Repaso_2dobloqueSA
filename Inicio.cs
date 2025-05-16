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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumAleatorio repaso1 = new NumAleatorio();
            repaso1.Show();
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlumnoAleatorio Repaso2 = new AlumnoAleatorio();
            Repaso2.Show();
        }
    }
}
