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
    public partial class guiConfirma : Form
    {
        Service1Client sc = new Service1Client();
        public guiConfirma()
        {
            InitializeComponent();
        }

        public guiConfirma(ServiceReference.Evento ev, ServiceReference.Cliente c, ServiceReference.FormaPagto fp, string valor)
        {
            InitializeComponent();
            ServiceReference.Evento evento = new ServiceReference.Evento();
            ServiceReference.Cliente cliente = new ServiceReference.Cliente();
            ServiceReference.Atracao atracao = new ServiceReference.Atracao();
            ServiceReference.RitmoEvento ritmoEvento = new ServiceReference.RitmoEvento();
            ServiceReference.Ritmo ritmo = new ServiceReference.Ritmo();
            ServiceReference.FormaPagto formaPagto = new ServiceReference.FormaPagto();

            cliente = sc.PesquisarCliente(c.CdCliente);
            evento = sc.PesquisarEvento(ev.CdEvento);
            atracao = sc.PesquisarAtracao(evento.CdAtracao.CdAtracao);
            ritmoEvento = sc.PesquisarRitmoEvento(evento.CdEvento);
            ritmo = sc.PesquisarRitmo(ritmoEvento.CdRitmo.CdRitmo);
            formaPagto = fp;

            labelEventoID.Text = evento.CdEvento.ToString();
            labelNmEvento.Text = evento.NmEvento;
            labelNmAtracao.Text = atracao.NmAtracao;
            labelNmRitmo.Text = ritmo.NmRitmo;
            labelDtEvento.Text = evento.DtEvento.ToString();
            labelTipoIngresso.Text = cliente.SxCliente.ToString();
            labelClienteId.Text = cliente.CdCliente.ToString();
            labelNmCliente.Text = cliente.NmCliente.ToString();
            labelDtCompra.Text = DateTime.Now.ToString();
            labelVlIng.Text = valor;
            labelFormaPagto.Text = formaPagto.DescFormaPagto.ToString();

            labelStatus.ForeColor = System.Drawing.Color.Red;
            labelStatus.Text = "NÃO ESTÁ PAGO";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference.Venda venda = new ServiceReference.Venda();
            ServiceReference.FormaPagtoVenda formaPagtoVenda = new ServiceReference.FormaPagtoVenda();
            ServiceReference.FormaPagto formaPagto = new ServiceReference.FormaPagto();
            ServiceReference.Cliente cliente = new Cliente();

            Service1Client sc = new Service1Client();

            //cliente = sc.PesquisarCliente(Convert.ToInt32(labelClienteId.Text));
            try
            {
                venda.CdCliente.CdCliente = Convert.ToInt32(labelClienteId.Text);
                venda.CdEvento.CdEvento = Convert.ToInt32(labelEventoID.Text);
                venda.DtVenda = DateTime.Now;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            
            formaPagto = sc.PesquisarFormaPagtoID(labelFormaPagto.Text);
            venda = sc.ProcurarId(venda.CdCliente.CdCliente, venda.CdEvento.CdEvento, venda.DtVenda);
            formaPagtoVenda.CdEvento.CdEvento = venda.CdEvento.CdEvento;
            formaPagtoVenda.CdFormaPagto.CdFormaPagto = formaPagto.CdFormaPagto;
            formaPagtoVenda.VlPago = Convert.ToDouble(labelVlIng.Text);

            // *****************
            // *     VENDA     *
            // *****************

            sc.NovaVenda(venda);
            sc.NovaFormaPagtoVenda(formaPagtoVenda);

            MessageBox.Show("Compra realizada com sucesso!");

            labelStatus.ForeColor = System.Drawing.Color.Green;
            labelStatus.Text = "PAGAMENTO CONFIRMADO!";            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
