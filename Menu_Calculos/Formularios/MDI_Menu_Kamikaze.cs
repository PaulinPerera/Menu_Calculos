using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos.Formularios
{
    public partial class MDI_Menu_Kamikaze : Form
    {
        public MDI_Menu_Kamikaze()
        {
            InitializeComponent();
        }

        private void orienToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void MDI_Menu_Kamikaze_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?",
                "Saindo...", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void cálculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            staDataHora.Text=DateTime.Now.ToString()
        }
    }
}

