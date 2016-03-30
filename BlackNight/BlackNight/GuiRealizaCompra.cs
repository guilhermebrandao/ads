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
    public partial class GuiRealizaCompra : Form
    {
        public List<ServiceReference.FormaPagto> lista;
        Service1Client sc = new Service1Client();

        public GuiRealizaCompra()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        public GuiRealizaCompra(string evento, string tipoIngresso)

        {
            InitializeComponent();
            textBox1.Focus();
            // Divide a String (cdEvento - nmEvento - dtEvento)
            string[] textEv = evento.Split('-');
            labelEventoID.Text = textEv[0];
            labelEvento.Text = textEv[1];
            labelDtNome.Text = textEv[2];
            labelTipoIngresso.Text = tipoIngresso;

            
            AlimentaComboBox();
            PrecoIngresso(Convert.ToInt32(labelEventoID.Text), tipoIngresso);                 
        }
        
        private void AlimentaComboBox()
        {
            lista = new List<ServiceReference.FormaPagto>();
            

            lista = sc.ListarFormaPagto().ToList<FormaPagto>();

            foreach (FormaPagto formasPagto in lista)
            {
                comboBox1.Items.Add(formasPagto.DescFormaPagto);
            }
        }

        private void PrecoIngresso(int id, string tipoIngresso)
        {
            // Define o preço do ingresso com base no genero do cliente.
            ServiceReference.Evento e;
            if (tipoIngresso == "Masculino")
            {
                sc = new Service1Client();
                e = new ServiceReference.Evento();

                e = sc.PesquisarEvento(id);

                labelPreco.Text = e.VlIngMasc.ToString();
            }
            else if (tipoIngresso == "Feminino")
            {
                sc = new Service1Client();
                e = new ServiceReference.Evento();

                e = sc.PesquisarEvento(id);

                labelPreco.Text = e.VlIngFem.ToString();
            }
        }
        private Boolean ValidaCampos()
        {

            ServiceReference.Cliente c = new ServiceReference.Cliente();
        
        
            Regex rgx = new Regex(@"[0-9]");
            if (string.IsNullOrEmpty(textBox1.Text) && (!rgx.IsMatch(textBox1.Text)))
            {
                MessageBox.Show("Código do cliente inválido!");
                return false;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Escolha um tipo de ingresso!");
                return false;
            }
            c = sc.PesquisarCliente(Convert.ToInt32(textBox1.Text));

            // Swtich para mudar o tipo do ingresso para ser compativel com o nome cadastrado no banco 'M' ou 'F'
            string tipoDoIngresso = labelTipoIngresso.Text;
            switch (tipoDoIngresso)
            {
                case "Masculino":
                    tipoDoIngresso = "M";
                    break;
                case "Feminino":
                    tipoDoIngresso = "F";
                    break;
            }
            // Valida se o cliente está apto à comprar aquele ingresso.
            if (c.SxCliente != tipoDoIngresso)
            {
                MessageBox.Show(c.NmCliente + " não está habilitado a comprar ingressos do tipo " + labelTipoIngresso.Text);
                return false;
            }
            return true;
        }
        private void buttonComprarIngresso_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                ServiceReference.Evento ev = new ServiceReference.Evento();
                ServiceReference.Cliente c = new ServiceReference.Cliente();
                ServiceReference.FormaPagto fp = new ServiceReference.FormaPagto();
                ServiceReference.Venda v = new ServiceReference.Venda();

                
                ev = sc.PesquisarEvento(Convert.ToInt32(labelEventoID.Text));
                c = sc.PesquisarCliente(Convert.ToInt32(textBox1.Text));
                fp.DescFormaPagto = comboBox1.Text;

                guiConfirma gC = new guiConfirma(ev, c, fp, labelPreco.Text);
                gC.Show();
            }
        }
    }
}
