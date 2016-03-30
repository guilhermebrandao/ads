namespace BlackNight
{
    partial class GuiCadastraRitmo
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxNmRitmo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCadastrar.Location = new System.Drawing.Point(101, 94);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 32);
            this.buttonCadastrar.TabIndex = 13;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancelar.Location = new System.Drawing.Point(182, 94);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 32);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxNmRitmo
            // 
            this.textBoxNmRitmo.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBoxNmRitmo.Location = new System.Drawing.Point(68, 62);
            this.textBoxNmRitmo.Name = "textBoxNmRitmo";
            this.textBoxNmRitmo.Size = new System.Drawing.Size(164, 26);
            this.textBoxNmRitmo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "CADASTRO DE RITMO";
            // 
            // GuiCadastraRitmo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 143);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxNmRitmo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GuiCadastraRitmo";
            this.Text = "Cadastro de Ritmos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxNmRitmo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}