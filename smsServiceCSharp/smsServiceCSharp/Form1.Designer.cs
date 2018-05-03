namespace smsServiceCSharp
{
    partial class Form1
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
            this.Button4 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(61, 96);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(109, 23);
            this.Button4.TabIndex = 15;
            this.Button4.Text = "Checar Créditos";
            this.Button4.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(6, 19);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(86, 36);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Ver Recebidas";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Mensagem";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(98, 19);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(116, 36);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Ver Recebidas Data";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Números";
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(349, 41);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 12;
            this.Button3.Text = "Enviar";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(77, 12);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(266, 20);
            this.txtMensagem.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(77, 38);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(266, 20);
            this.txtNumero.TabIndex = 10;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Location = new System.Drawing.Point(231, 70);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(228, 67);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Checar Recebimento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 140);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.TextBox txtMensagem;
        internal System.Windows.Forms.TextBox txtNumero;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}

