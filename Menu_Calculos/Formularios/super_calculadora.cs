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

        private void super_calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lblVisor.Text);
            decimal resultado = 0;

            switch (vOperacao)
            {
                case "+": resultado = vNumAnt + vNumAtual; break;
                case "-": resultado = vNumAnt - vNumAtual; break;
                case "x": resultado = vNumAnt * vNumAtual; break;
                case ":":
                    if (vNumAtual == 0) { lblVisor.Text = "Erro: div/0"; return; }
                    resultado = vNumAnt / vNumAtual;
                    break;
            }
            
            lblHistorico.Text = vNumAnt + " " + vOperacao + " " + vNumAtual + " = " + resultado;

            lblVisor.Text = resultado.ToString();
            vNumAnt = resultado;  // permite encadear operações
            vLimparVisor = true;
            lblVisor.Focus();
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!lblVisor.Text.Contains(","))
            {  lblVisor.Text += ","; }
            lblVisor.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            vNumAnt  = 0;
            lblVisor.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblVisor.Text=lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            if(lblVisor.Text=="") lblVisor.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                case Keys.Return:
                    button19_Click(botao, e);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void lblVisor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
