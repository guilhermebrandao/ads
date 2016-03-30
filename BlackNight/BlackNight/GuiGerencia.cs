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
    public partial class GuiGerencia : Form
    {
        Service1Client sc = new Service1Client();
        ServiceReference.Cliente c;
        ServiceReference.Evento ev;
        ServiceReference.Atracao a;
        ServiceReference.Ritmo r;
        public GuiGerencia()
        {
            InitializeComponent();
            // CarregarTabelas();

        }

        private void CarregarTabelas()
        {
            // Table de clientes
            c = new ServiceReference.Cliente();
            List<Cliente> listaClientes = sc.ListarClientes().ToList();
            dataGridViewCliente.DataSource = listaClientes;

            // Table de Eventos
            ev = new ServiceReference.Evento();
            List<Evento> listaEventos = sc.ListarEventos().ToList();
            dataGridViewEvento.DataSource = listaEventos;

            // Table de Atrações
            a = new ServiceReference.Atracao();
            List<Atracao> listaAtracoes = sc.ListarAtracoes().ToList();
            dataGridViewAtracao.DataSource = listaAtracoes;

            // Table de Ritmo
            r = new ServiceReference.Ritmo();
            List<Ritmo> listaRitmos = sc.ListarRitmos().ToList();
            dataGridViewRitmo.DataSource = listaRitmos;


        }

        #region Tab Cliente
        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            GuiCadastroCliente gGC = new GuiCadastroCliente();
            gGC.Visible = true;
        }
        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            c = new ServiceReference.Cliente();
            c = sc.PesquisarCliente(Convert.ToInt32(textBoxClienteID.Text));
            dataGridViewCliente.DataSource = c;
        }
        private void buttonDeletearCliente_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewCliente.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridViewCliente.Rows[rowIndex];
            c = new ServiceReference.Cliente();
            c = sc.ListarClientes().ElementAt(row.Index);
            try
            {
                if (MessageBox.Show("Tem certeza que você deseja deletar " + c.NmCliente + "?", "Confirmar Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sc.ExcluirCliente(c);
                    MessageBox.Show("Cliente excluido com sucesso!", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar excluir!\n" + ex.Message, "Erro na exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataGridViewCliente.DataSource = sc.ListarClientes();
            }
        }

        #endregion


        #region Tab Evento
        private void buttonAdicionarEvento_Click(object sender, EventArgs e)
        {
            GuiCadastraEvento gCE = new GuiCadastraEvento();
            gCE.Visible = true;
        }
        private void buttonDeletarEvento_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewEvento.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridViewEvento.Rows[rowIndex];
            ev = new ServiceReference.Evento();
            ev = sc.ListarEventos().ElementAt(row.Index);
            try
            {
                if (MessageBox.Show("Tem certeza que você deseja deletar " + ev.NmEvento + "?", "Confirmar Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sc.ExcluirEvento(ev);
                    MessageBox.Show("Cliente excluido com sucesso!", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar excluir!\n" + ex.Message, "Erro na exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataGridViewEvento.DataSource = sc.ListarEventos();
            }
        }
        private void buttonBuscarEvento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCdEvento.Text))
            {
                MessageBox.Show("O campo código do evento não pode ser deixado em branco.");
                textBoxCdEvento.Focus();
            }
            else
            {
                dataGridViewEvento.DataSource = sc.PesquisarEvento(Convert.ToInt32(textBoxCdEvento.Text));
            }
        }
        #endregion


        #region Tab Atração | Ritmo
        private void buttonAdicionarAtracao_Click(object sender, EventArgs e)
        {
            GuiCadastroAtração gCA = new GuiCadastroAtração();
            gCA.Visible = true;
        }
        private void buttonDeletarAtracao_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewAtracao.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridViewAtracao.Rows[rowIndex];
            a = new ServiceReference.Atracao();
            a = sc.ListarAtracoes().ElementAt(row.Index);
            try
            {
                if (MessageBox.Show("Tem certeza que você deseja deletar " + a.NmAtracao + "?", "Confirmar Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    MessageBox.Show("Cliente excluido com sucesso!", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar excluir!\n" + ex.Message, "Erro na exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataGridViewAtracao.DataSource = sc.ListarAtracoes();
            }
        }
        private void buttonBuscarAtracao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCdAtracao.Text))
            {
                MessageBox.Show("O campo código da Atração não pode ser deixado em branco.");
                textBoxCdAtracao.Focus();
            }
            else
            {
                dataGridViewAtracao.DataSource = sc.PesquisarAtracao(Convert.ToInt32(textBoxCdAtracao.Text));
            }
        }


        private void buttonAdicionarRitmo_Click(object sender, EventArgs e)
        {
            GuiCadastraRitmo gCR = new GuiCadastraRitmo();
            gCR.Visible = true;
        }
        private void buttonDeletarRitmo_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewRitmo.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridViewRitmo.Rows[rowIndex];
            r = new ServiceReference.Ritmo();
            r = sc.ListarRitmos().ElementAt(row.Index);
            try
            {
                if (MessageBox.Show("Tem certeza que você deseja deletar " + r.NmRitmo + "?", "Confirmar Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    MessageBox.Show("Cliente excluido com sucesso!", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar excluir!\n" + ex.Message, "Erro na exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataGridViewAtracao.DataSource = sc.ListarRitmos();
            }
        }
        private void buttonBuscarRitmo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCdRitmo.Text))
            {
                MessageBox.Show("O campo código do Ritmo não pode ser deixado em branco.");
                textBoxCdRitmo.Focus();
            }
            else
            {
                dataGridViewRitmo.DataSource = sc.PesquisarRitmo(Convert.ToInt32(textBoxCdRitmo.Text));
            }
        }
        #endregion


        #region Fechar e Socket
        private void buttonHabilitarSocket_Click(object sender, EventArgs e)
        {
            GuiServerSocket gSS = new GuiServerSocket();
            gSS.Show();

        }
        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }



        #endregion
    }
}
