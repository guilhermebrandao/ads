namespace BlackNight
{
    partial class guiIncial
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
            this.buttonComprar = new System.Windows.Forms.Button();
            this.buttonGerenciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonComprar
            // 
            this.buttonComprar.Location = new System.Drawing.Point(12, 12);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(228, 60);
            this.buttonComprar.TabIndex = 1;
            this.buttonComprar.Text = "COMPRAR INGRESSO";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // buttonGerenciar
            // 
            this.buttonGerenciar.Location = new System.Drawing.Point(12, 103);
            this.buttonGerenciar.Name = "buttonGerenciar";
            this.buttonGerenciar.Size = new System.Drawing.Size(228, 60);
            this.buttonGerenciar.TabIndex = 2;
            this.buttonGerenciar.Text = "GERENCIAR VENDAS";
            this.buttonGerenciar.UseVisualStyleBackColor = true;
            this.buttonGerenciar.Click += new System.EventHandler(this.buttonGerenciar_Click);
            // 
            // guiIncial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 176);
            this.Controls.Add(this.buttonGerenciar);
            this.Controls.Add(this.buttonComprar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "guiIncial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem Vindo!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.Button buttonGerenciar;
    }
}