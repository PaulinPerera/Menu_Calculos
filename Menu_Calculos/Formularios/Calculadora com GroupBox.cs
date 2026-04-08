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
        private void bntCalcular_Click(object sender, EventArgs e)
        {
            decimal a, b;
            try
            {
                a = decimal.Parse(txtN1.Text);
                b = decimal.Parse(txtN2.Text);
                if (RadBSomar.Checked)
                {
                    lblResultado.Text = (a + b).ToString();

                }
                else if (RadBSubtrair.Checked)
                {
                    lblResultado.Text = (a - b).ToString();
                }
                else if (RadBMultiplicar.Checked)
                {
                    lblResultado.Text = (a * b).ToString();
                }
                else if (RadBDividir.Checked)
                {
                    lblResultado.Text = (a / b).ToString();
                }
                else if (RadBPotencia.Checked)
                {
                    lblResultado.Text = ((decimal)Math.Pow((double)a, (double)b)).ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Impossível divisão por zero");
            }
        }
         private void RadBSomar_CheckedChanged(object sender, EventArgs e)
        {
            lbl_alg.Text = "+";
        }
        private void RadBSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            lbl_alg.Text = "-";
        }
        private void RadBMultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            lbl_alg.Text = "X";
        }
        private void RadBDividir_CheckedChanged(object sender, EventArgs e)
        {
            lbl_alg.Text = "÷";
        }
        private void RadBPotencia_CheckedChanged(object sender, EventArgs e)
        {
            lbl_alg.Text = "^";
        }

        private void Calculadora_com_GroupBox_Load(object sender, EventArgs e)
        {
            this.AcceptButton = bntCalcular;
        }
    }
}
