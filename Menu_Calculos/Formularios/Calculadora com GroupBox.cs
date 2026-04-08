using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Menu_Calculos
{
    public partial class Calculadora_com_GroupBox : Form
    {
        public Calculadora_com_GroupBox()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblSinal_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_com_GroupBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimparTexto_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            lblResultado.Text = "";
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void RadBSomar_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
