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
    public partial class GuiCadastraEvento : Form
    {
        public GuiCadastraEvento()
        {
            InitializeComponent();
            textBoxCdAtracao.Focus();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ServiceReference.Evento ev = new ServiceReference.Evento();
                Service1Client sc = new Service1Client();

                ev.CdAtracao.CdAtracao = Convert.ToInt32(textBoxCdAtracao.Text);
                ev.NmEvento = textBoxNmEvento.Text;
                ev.DtEvento = Convert.ToDateTime(textBoxDtEvento.Text);
                ev.QtdIngFem = Convert.ToInt32(textBoxQtdIngFem.Text);
                ev.VlIngFem = Convert.ToDecimal(textBoxVlIngFem.Text);
                ev.QtdIngMasc = Convert.ToInt32(textBoxQtdIngMasc.Text);
                ev.VlIngMasc = Convert.ToDecimal(textBoxVlIngMasc.Text);

                sc.NovoEvento(ev);
            }
        }

        private Boolean ValidarCampos()
        {
            if (string.IsNullOrEmpty(textBoxCdAtracao.Text))
            {
                MessageBox.Show("O campo código da atração não pode ser deixado em branco.");
                textBoxCdAtracao.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxNmEvento.Text))
            {
                MessageBox.Show("O campo nome do evento não pode ser deixado em branco.");
                textBoxNmEvento.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxDtEvento.Text))
            {
                MessageBox.Show("O cmapo data do evento não pode ser deixado em branco.");
                textBoxDtEvento.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxQtdIngFem.Text))
            {
                MessageBox.Show("O campo quantidade de ingressos femininos não pode ser deixado em branco.");
                textBoxQtdIngFem.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxVlIngFem.Text))
            {
                MessageBox.Show("O campo valor dos ingressos femininos não pode ser deixado em branco.");
                textBoxVlIngFem.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxQtdIngMasc.Text))
            {
                MessageBox.Show("O campo quantidade de ingressos masculinos não pode ser deixado em branco.");
                textBoxQtdIngMasc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxVlIngMasc.Text))
            {
                MessageBox.Show("O campo valor dos ingressos masculinos não pode ser deixado em branco.");
                textBoxVlIngFem.Focus();
                return false;
            }
            return true;
        }
    }
}
