using BlackNight.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackNight
{
    public partial class GuiCadastroAtração : Form
    {
        public GuiCadastroAtração()
        {
            InitializeComponent();
            textBoxNmAtracao.Focus();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            ServiceReference.Atracao a = new ServiceReference.Atracao();
            Service1Client sc = new Service1Client();

            if (ValidaCampos())
            {
                a.NmAtracao = textBoxNmAtracao.Text;
                a.NumAtracao = textBoxNumAtracao.Text;
                try
                {
                    sc.NovaAtracao(a);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private Boolean ValidaCampos()
        {
            if (string.IsNullOrEmpty(textBoxNmAtracao.Text))
            {
                MessageBox.Show("O nome da Atração não pode ser deixado em branco.");
                textBoxNmAtracao.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxNumAtracao.Text))
            {
                MessageBox.Show("O número do telefone da Atração não pode ser deixado em branco.");
                textBoxNumAtracao.Focus();
                return false;
            }
            return true;
        }
    }
}
