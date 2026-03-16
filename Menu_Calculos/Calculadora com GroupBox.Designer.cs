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
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblSinal = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimparTexto = new System.Windows.Forms.Button();
            this.gbButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbButton
            // 
            this.gbButton.Controls.Add(this.radioButton5);
            this.gbButton.Controls.Add(this.radioButton1);
            this.gbButton.Controls.Add(this.radioButton4);
            this.gbButton.Controls.Add(this.radioButton2);
            this.gbButton.Controls.Add(this.radioButton3);
            this.gbButton.Location = new System.Drawing.Point(46, 59);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(164, 223);
            this.gbButton.TabIndex = 0;
            this.gbButton.TabStop = false;
            this.gbButton.Text = "Operações";
            this.gbButton.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(15, 166);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(122, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Potenciação";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Somar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 136);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(76, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Dividir";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Subtrair";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 106);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Multiplicar";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lblSinal
            // 
            this.lblSinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.Location = new System.Drawing.Point(416, 97);
            this.lblSinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(33, 32);
            this.lblSinal.TabIndex = 3;
            this.lblSinal.Text = "?";
            this.lblSinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSinal.Click += new System.EventHandler(this.lblSinal_Click);
            // 
            // txtN1
            // 
            this.txtN1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtN1.Location = new System.Drawing.Point(457, 97);
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
            this.txtN2.Location = new System.Drawing.Point(457, 137);
            this.txtN2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(188, 30);
            this.txtN2.TabIndex = 5;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(457, 225);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(188, 34);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "?";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimparTexto
            // 
            this.btnLimparTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTexto.Location = new System.Drawing.Point(494, 264);
            this.btnLimparTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimparTexto.Name = "btnLimparTexto";
            this.btnLimparTexto.Size = new System.Drawing.Size(112, 45);
            this.btnLimparTexto.TabIndex = 7;
            this.btnLimparTexto.Text = "&Limpar";
            this.btnLimparTexto.UseVisualStyleBackColor = true;
            // 
            // Calculadora_com_GroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimparTexto);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.gbButton);
            this.Name = "Calculadora_com_GroupBox";
            this.Text = "Cálculos com RadioButtons";
            this.gbButton.ResumeLayout(false);
            this.gbButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimparTexto;
    }
}