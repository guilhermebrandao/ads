namespace BlackNight
{
    partial class GuiServerSocket
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
            this.buttonEnviarMensagem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxMensagensRecebidas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEnviarMensagem
            // 
            this.buttonEnviarMensagem.Location = new System.Drawing.Point(28, 62);
            this.buttonEnviarMensagem.Name = "buttonEnviarMensagem";
            this.buttonEnviarMensagem.Size = new System.Drawing.Size(155, 23);
            this.buttonEnviarMensagem.TabIndex = 0;
            this.buttonEnviarMensagem.Text = "Enviar Mensagem";
            this.buttonEnviarMensagem.UseVisualStyleBackColor = true;
            this.buttonEnviarMensagem.Click += new System.EventHandler(this.buttonEnviarMensagem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxMensagensRecebidas);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 136);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mensagens recebidas";
            // 
            // listBoxMensagensRecebidas
            // 
            this.listBoxMensagensRecebidas.FormattingEnabled = true;
            this.listBoxMensagensRecebidas.Location = new System.Drawing.Point(6, 20);
            this.listBoxMensagensRecebidas.Name = "listBoxMensagensRecebidas";
            this.listBoxMensagensRecebidas.Size = new System.Drawing.Size(180, 108);
            this.listBoxMensagensRecebidas.TabIndex = 1;
            // 
            // GuiServerSocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 240);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonEnviarMensagem);
            this.Name = "GuiServerSocket";
            this.Text = "Socket: DIGITAR MESA VAGA";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnviarMensagem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxMensagensRecebidas;
    }
}