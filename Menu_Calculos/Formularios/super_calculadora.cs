using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos
{
    public partial class super_calculadora : Form
    {
        decimal vNumAnt;
        string vOperacao;
        bool vLimparVisor;
        public super_calculadora()
        {
            InitializeComponent();
        }
        private void f_digitos(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;
            if (lblVisor.Text == "0" || vLimparVisor)
            {
                lblVisor.Text = "";
                vLimparVisor = false;
            }

            lblVisor.Text += digito;
        }
        private void f_operadores(object sender, EventArgs e)
        {
            vNumAnt = decimal.Parse(lblVisor.Text);
            vOperacao = ((Button)sender).Text;
            vLimparVisor = true;
            lblHistorico.Text = "";
            lblHistorico.Text = vNumAnt + " " + vOperacao + " ";
            lblVisor.Focus();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vOperacao)) return;

            decimal vNumAtual = decimal.Parse(lblVisor.Text);
            switch (vOperacao)
            {
                case "+":
                    lblVisor.Text = (vNumAnt + vNumAtual).ToString();
                    break;
                case "-":
                    lblVisor.Text = (vNumAnt - vNumAtual).ToString();
                    break;
                case "x":
                    lblVisor.Text = (vNumAnt * vNumAtual).ToString();
                    break;
                case ":":
                    if (vNumAtual == 0)
                    {
                        MessageBox.Show("Divisão por zero não é permitida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblVisor.Text = "0";
                    }
                    else
                    {
                        lblVisor.Text = (vNumAnt / vNumAtual).ToString();
                    }
                    break;
                case "^":
                    lblVisor.Text = ((decimal)Math.Pow((double)vNumAnt, (double)vNumAtual)).ToString();
                    break;
            }

            lblHistorico.Text = vNumAnt + " " + vOperacao + " " + vNumAtual;

            vOperacao = null;
            vLimparVisor = true;
            lblVisor.Focus();
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!lblVisor.Text.Contains(","))
            { lblVisor.Text += ","; }
            lblVisor.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            vNumAnt = 0;
            vOperacao = null;
            lblHistorico.Text = "";
            lblVisor.Text = "0";
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "0";
            vLimparVisor = false;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lblVisor.Text.Length > 0)
            {
                lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            }
            if (lblVisor.Text == "" || lblVisor.Text == "-") lblVisor.Text = "0";
        }
        private void frmCalculadoraVisorUnico_KeyDown(object sender, KeyEventArgs e)
        {
            lblNumAtual.Text = e.KeyCode.ToString();
            Button botao = new Button();

            if (e.KeyCode == Keys.Escape)
            {
                Close();
                return;
            }

            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                botao.Text = e.KeyCode.ToString().Substring(6);
                foreach (Control bot in panel1.Controls)
                {
                    if (((Button)bot).Text == botao.Text)
                        bot.BackColor = Color.Gray;
                }
                f_digitos(botao, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !e.Shift)
            {
                botao.Text = ((int)(e.KeyCode - Keys.D0)).ToString();
                f_digitos(botao, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.Add:
                    botao.Text = "+";
                    f_operadores(botao, e);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Subtract:
                    botao.Text = "-";
                    f_operadores(botao, e);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Multiply:
                    botao.Text = "x";
                    f_operadores(botao, e);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Divide:
                    botao.Text = ":";
                    f_operadores(botao, e);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Return:
                    button19_Click(botao, e);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Back:
                    btnBack_Click(botao, e);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
            }
        }
        private void super_calculadora_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                control.BackColor = Color.White;
            }
            foreach (Control control in panel2.Controls)
            {
                control.BackColor = Color.White;
                if (control.Text == "=")
                {
                    control.BackColor = Color.LightSeaGreen;
                }
            }
        }
        private void bntSinal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblVisor.Text, out double valor))
            {
                lblVisor.Text = (valor * -1).ToString();
            }
        }

        private void super_calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
