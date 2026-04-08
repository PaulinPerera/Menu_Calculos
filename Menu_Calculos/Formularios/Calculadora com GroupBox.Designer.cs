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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbButton
            // 
            this.gbButton.BackColor = System.Drawing.Color.Firebrick;
            this.gbButton.Controls.Add(this.radioButton5);
            this.gbButton.Controls.Add(this.radioButton1);
            this.gbButton.Controls.Add(this.radioButton4);
            this.gbButton.Controls.Add(this.radioButton2);
            this.gbButton.Controls.Add(this.radioButton3);
            this.gbButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbButton.Location = new System.Drawing.Point(31, 36);
            this.gbButton.Margin = new System.Windows.Forms.Padding(2);
            this.gbButton.Name = "gbButton";
            this.gbButton.Padding = new System.Windows.Forms.Padding(2);
            this.gbButton.Size = new System.Drawing.Size(109, 133);
            this.gbButton.TabIndex = 0;
            this.gbButton.TabStop = false;
            this.gbButton.Text = "Operações";
            this.gbButton.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(10, 108);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Potenciação";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 30);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Somar";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadBSomar_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(10, 88);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(54, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Dividir";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 49);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Subtrair";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 69);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Multiplicar";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lblSinal
            // 
            this.lblSinal.BackColor = System.Drawing.Color.Firebrick;
            this.lblSinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSinal.Location = new System.Drawing.Point(171, 49);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(26, 25);
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
            this.txtN1.Location = new System.Drawing.Point(203, 36);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(127, 22);
            this.txtN1.TabIndex = 4;
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtN1.TextChanged += new System.EventHandler(this.txtN1_TextChanged);
            // 
            // txtN2
            // 
            this.txtN2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(203, 64);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(127, 22);
            this.txtN2.TabIndex = 5;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtN2.TextChanged += new System.EventHandler(this.txtN2_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Firebrick;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultado.Location = new System.Drawing.Point(203, 101);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(127, 36);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "?";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.txtN2_TextChanged);
            // 
            // btnLimparTexto
            // 
            this.btnLimparTexto.BackColor = System.Drawing.Color.White;
            this.btnLimparTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTexto.Location = new System.Drawing.Point(203, 140);
            this.btnLimparTexto.Name = "btnLimparTexto";
            this.btnLimparTexto.Size = new System.Drawing.Size(127, 29);
            this.btnLimparTexto.TabIndex = 7;
            this.btnLimparTexto.Text = "&Limpar";
            this.btnLimparTexto.UseVisualStyleBackColor = false;
            this.btnLimparTexto.Click += new System.EventHandler(this.btnLimparTexto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(203, 171);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Calculadora_com_GroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(362, 237);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimparTexto);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.gbButton);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}