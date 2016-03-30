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
    public partial class guiCompra : Form
    {
        public static Service1Client sc = new Service1Client();
        public static List<ServiceReference.Evento> lista;
        public guiCompra()
        {
            InitializeComponent();
            AlimentaComboBoxes();
            
        }
        private Boolean ValidaComboBox()
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Selecione um evento!");
                return false;
            }
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Selecione o tipo do ingresso");
                return false;
            }
            return true;
        }
        public void AlimentaComboBoxes()
        {
            lista = new List<ServiceReference.Evento>();
            
            
            lista = sc.ListarEventos().ToList<Evento>();

            foreach (Evento eventos in lista)
            {
                comboBox1.Items.Add(eventos.CdEvento + " - " + eventos.NmEvento + " - " + eventos.DtEvento);
            }            
            
        }
        private void buttonComprar_Click(object sender, EventArgs e)
        {
            if (ValidaComboBox())
            {
                if ((MessageBox.Show("Já é cadastrado?", "Confirmar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
                {
                    GuiCadastroCliente gCC = new GuiCadastroCliente();
                    gCC.Show();
                }
                else
                {
                    GuiRealizaCompra gRC = new GuiRealizaCompra(comboBox1.Text, comboBox2.Text);
                    gRC.Show();
                }
            }
        }
    }
}
