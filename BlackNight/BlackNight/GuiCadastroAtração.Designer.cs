namespace BlackNight
{
    partial class GuiCadastroAtração
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiCadastroAtração));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNmAtracao = new System.Windows.Forms.TextBox();
            this.textBoxNumAtracao = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxNmAtracao
            // 
            resources.ApplyResources(this.textBoxNmAtracao, "textBoxNmAtracao");
            this.textBoxNmAtracao.Name = "textBoxNmAtracao";
            // 
            // textBoxNumAtracao
            // 
            resources.ApplyResources(this.textBoxNumAtracao, "textBoxNumAtracao");
            this.textBoxNumAtracao.Name = "textBoxNumAtracao";
            // 
            // buttonCancelar
            // 
            resources.ApplyResources(this.buttonCancelar, "buttonCancelar");
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonCadastrar
            // 
            resources.ApplyResources(this.buttonCadastrar, "buttonCadastrar");
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // GuiCadastroAtração
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxNumAtracao);
            this.Controls.Add(this.textBoxNmAtracao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GuiCadastroAtração";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNmAtracao;
        private System.Windows.Forms.TextBox textBoxNumAtracao;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonCadastrar;
    }
}