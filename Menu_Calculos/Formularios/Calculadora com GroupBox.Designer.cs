namespace Menu_Calculos
{
    partial class Calculadora_com_GroupBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.RadBPotencia = new System.Windows.Forms.RadioButton();
            this.RadBSomar = new System.Windows.Forms.RadioButton();
            this.RadBDividir = new System.Windows.Forms.RadioButton();
            this.RadBSubtrair = new System.Windows.Forms.RadioButton();
            this.RadBMultiplicar = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_alg = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimparTexto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.gbButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbButton
            // 
            this.gbButton.BackColor = System.Drawing.Color.Firebrick;
            this.gbButton.Controls.Add(this.RadBPotencia);
            this.gbButton.Controls.Add(this.RadBSomar);
            this.gbButton.Controls.Add(this.RadBDividir);
            this.gbButton.Controls.Add(this.RadBSubtrair);
            this.gbButton.Controls.Add(this.RadBMultiplicar);
            this.gbButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbButton.Location = new System.Drawing.Point(46, 55);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(164, 205);
            this.gbButton.TabIndex = 0;
            this.gbButton.TabStop = false;
            this.gbButton.Text = "Operações";
            // 
            // RadBPotencia
            // 
            this.RadBPotencia.AutoSize = true;
            this.RadBPotencia.Location = new System.Drawing.Point(15, 166);
            this.RadBPotencia.Name = "RadBPotencia";
            this.RadBPotencia.Size = new System.Drawing.Size(122, 24);
            this.RadBPotencia.TabIndex = 4;
            this.RadBPotencia.TabStop = true;
            this.RadBPotencia.Text = "Potenciação";
            this.RadBPotencia.UseVisualStyleBackColor = true;
            this.RadBPotencia.CheckedChanged += new System.EventHandler(this.RadBPotencia_CheckedChanged);
            // 
            // RadBSomar
            // 
            this.RadBSomar.AutoSize = true;
            this.RadBSomar.Location = new System.Drawing.Point(15, 46);
            this.RadBSomar.Name = "RadBSomar";
            this.RadBSomar.Size = new System.Drawing.Size(81, 24);
            this.RadBSomar.TabIndex = 0;
            this.RadBSomar.TabStop = true;
            this.RadBSomar.Text = "Somar";
            this.RadBSomar.UseVisualStyleBackColor = true;
            this.RadBSomar.CheckedChanged += new System.EventHandler(this.RadBSomar_CheckedChanged);
            // 
            // RadBDividir
            // 
            this.RadBDividir.AutoSize = true;
            this.RadBDividir.Location = new System.Drawing.Point(15, 135);
            this.RadBDividir.Name = "RadBDividir";
            this.RadBDividir.Size = new System.Drawing.Size(76, 24);
            this.RadBDividir.TabIndex = 3;
            this.RadBDividir.TabStop = true;
            this.RadBDividir.Text = "Dividir";
            this.RadBDividir.UseVisualStyleBackColor = true;
            this.RadBDividir.CheckedChanged += new System.EventHandler(this.RadBDividir_CheckedChanged);
            // 
            // RadBSubtrair
            // 
            this.RadBSubtrair.AutoSize = true;
            this.RadBSubtrair.Location = new System.Drawing.Point(15, 75);
            this.RadBSubtrair.Name = "RadBSubtrair";
            this.RadBSubtrair.Size = new System.Drawing.Size(90, 24);
            this.RadBSubtrair.TabIndex = 1;
            this.RadBSubtrair.TabStop = true;
            this.RadBSubtrair.Text = "Subtrair";
            this.RadBSubtrair.UseVisualStyleBackColor = true;
            this.RadBSubtrair.CheckedChanged += new System.EventHandler(this.RadBSubtrair_CheckedChanged);
            // 
            // RadBMultiplicar
            // 
            this.RadBMultiplicar.AutoSize = true;
            this.RadBMultiplicar.Location = new System.Drawing.Point(15, 106);
            this.RadBMultiplicar.Name = "RadBMultiplicar";
            this.RadBMultiplicar.Size = new System.Drawing.Size(104, 24);
            this.RadBMultiplicar.TabIndex = 2;
            this.RadBMultiplicar.TabStop = true;
            this.RadBMultiplicar.Text = "Multiplicar";
            this.RadBMultiplicar.UseVisualStyleBackColor = true;
            this.RadBMultiplicar.CheckedChanged += new System.EventHandler(this.RadBMultiplicar_CheckedChanged);
            // 
            // lbl_alg
            // 
            this.lbl_alg.BackColor = System.Drawing.Color.Firebrick;
            this.lbl_alg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_alg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_alg.Location = new System.Drawing.Point(258, 74);
            this.lbl_alg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_alg.Name = "lbl_alg";
            this.lbl_alg.Size = new System.Drawing.Size(38, 37);
            this.lbl_alg.TabIndex = 3;
            this.lbl_alg.Text = "?";
            this.lbl_alg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtN1
            // 
            this.txtN1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtN1.Location = new System.Drawing.Point(304, 55);
            this.txtN1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(188, 30);
            this.txtN1.TabIndex = 4;
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN2
            // 
            this.txtN2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(304, 98);
            this.txtN2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(188, 30);
            this.txtN2.TabIndex = 5;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Firebrick;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultado.Location = new System.Drawing.Point(304, 155);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(190, 54);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "?";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimparTexto
            // 
            this.btnLimparTexto.BackColor = System.Drawing.Color.White;
            this.btnLimparTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTexto.Location = new System.Drawing.Point(304, 215);
            this.btnLimparTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimparTexto.Name = "btnLimparTexto";
            this.btnLimparTexto.Size = new System.Drawing.Size(190, 45);
            this.btnLimparTexto.TabIndex = 7;
            this.btnLimparTexto.Text = "&Limpar";
            this.btnLimparTexto.UseVisualStyleBackColor = false;
            this.btnLimparTexto.Click += new System.EventHandler(this.btnLimparTexto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(45, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntCalcular
            // 
            this.bntCalcular.BackColor = System.Drawing.Color.White;
            this.bntCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCalcular.Location = new System.Drawing.Point(304, 264);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(190, 46);
            this.bntCalcular.TabIndex = 9;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = false;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // Calculadora_com_GroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(543, 365);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimparTexto);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lbl_alg);
            this.Controls.Add(this.gbButton);
            this.Name = "Calculadora_com_GroupBox";
            this.Text = "Cálculos com RadioButtons";
            this.Load += new System.EventHandler(this.Calculadora_com_GroupBox_Load);
            this.gbButton.ResumeLayout(false);
            this.gbButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton RadBPotencia;
        private System.Windows.Forms.RadioButton RadBSomar;
        private System.Windows.Forms.RadioButton RadBDividir;
        private System.Windows.Forms.RadioButton RadBSubtrair;
        private System.Windows.Forms.RadioButton RadBMultiplicar;
        private System.Windows.Forms.Label lbl_alg;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimparTexto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntCalcular;
    }
}