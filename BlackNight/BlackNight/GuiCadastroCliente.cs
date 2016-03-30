//using Biblioteca.Basicas;
//using Biblioteca.erros;
//using Biblioteca.negocios;
using BlackNight.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackNight
{
    public partial class GuiCadastroCliente : Form
    {
        Service1Client sc = new Service1Client();
        public GuiCadastroCliente()
        {
            InitializeComponent();
            textBoxNome.Focus();          

        }


        public Boolean ValidaCampos()
        {
            Regex rgx = new Regex(@"[0-9]");
            Regex rgxEmail = new Regex(@"^[\S +@\S +$]");
            Regex rgxNome = new Regex(@"^[a-zA-Z]");

            if ((!rgxNome.IsMatch(textBoxNome.Text)) && (string.IsNullOrEmpty(textBoxNome.Text)))
            {
                MessageBox.Show("Nome do Cliente inválido!");
                return false;
            }
            if ((!rgx.IsMatch(textBoxCpf.Text)) && (string.IsNullOrEmpty(textBoxCpf.Text)))
            {
                MessageBox.Show("CPF do Cliente inválido!");
                return false;
            }
            if ((!rgx.IsMatch(textBoxTel.Text)) && (string.IsNullOrEmpty(textBoxTel.Text)))
            {
                MessageBox.Show("Telefone do Cliente inválido!");
                return false;
            }
            if (string.IsNullOrEmpty(textBoxDtNasc.Text))
            {
                MessageBox.Show("Data de Nascimento inválida!");
            }
            if ((!rgxEmail.IsMatch(textBoxEmail.Text)) && (string.IsNullOrEmpty(textBoxEmail.Text)))
            {
                MessageBox.Show("Email do Cliente inválido!");
                return false;
            }

            return true;
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
               
                try
                {
                    ServiceReference.Cliente c = new ServiceReference.Cliente();
                    if (radioButtonAtualizar.Checked)
                    {
                        c.CdCliente = Convert.ToInt32(textBoxClienteId.Text);
                    }
                    else
                    {

                        c.NmCliente = textBoxNome.Text;
                        c.CpfCliente = textBoxCpf.Text;
                        c.NumCliente = textBoxTel.Text;
                        c.DtNascCliente = Convert.ToDateTime(textBoxDtNasc.Text);
                        c.SxCliente = comboBoxSx.Text;
                        c.EmailCliente = textBoxEmail.Text;
                    }

                    sc.NovoCliente(c);
                    if ((MessageBox.Show("Cliente Cadastrado com sucesso!!\n\n Deseja voltar as compras?", "Confirmar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        GuiRealizaCompra gRC = new GuiRealizaCompra();
                        gRC.Show();
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar cadastrar cliente!\n" + ex.Message);
                }
            }
        }

        private void radioButtonAtualizar_Click(object sender, EventArgs e)
        {
            textBoxClienteId.ReadOnly = false;
        }
    }
}
