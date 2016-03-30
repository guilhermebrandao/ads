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
    public partial class GuiCadastraRitmo : Form
    {
        public GuiCadastraRitmo()
        {
            InitializeComponent();
            textBoxNmRitmo.Focus();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                ServiceReference.Ritmo r = new ServiceReference.Ritmo();
                Service1Client sc = new Service1Client();

                r.NmRitmo = textBoxNmRitmo.Text;

                sc.NovoRitmo(r);
            }
        }

        private Boolean ValidaCampos()
        {
            if (string.IsNullOrEmpty(textBoxNmRitmo.Text))
            {
                MessageBox.Show("O nome do Ritmo não pode ser deixado em branco.");
                textBoxNmRitmo.Focus();
                return false;
            }
            return true;
        }
    }
}
