using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.Basicas;
using Biblioteca.negocios;

namespace WcfBlackNight
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        // Venda
        public void NovaVenda(Venda v)
        {
            BLLVenda bVenda = new BLLVenda();
            bVenda.Inserir(v);
        }
        public List<Venda> ListarVendas()
        {
            BLLVenda bVenda = new BLLVenda();
            return bVenda.Lista();
        }
        public Venda ProcurarId(int idCliente, int idEvento, DateTime dtEvento)
        {
            BLLVenda bVenda = new BLLVenda();
            return bVenda.PesquisaVenda(idCliente, idEvento, dtEvento);
        }
        public Venda PesquisarVenda(int id)
        {
            BLLVenda bVenda = new BLLVenda();
            return bVenda.PesquisaVenda(id);
        }


        // Evento
        public void NovoEvento(Evento ev)
        {
            BLLEvento bEvento = new BLLEvento();
            bEvento.Inserir(ev);
        }
        public List<Evento> ListarEventos()
        {
            BLLEvento bEvento = new BLLEvento();
            return bEvento.Lista();
        }
        public DateTime ListarHoraDoEvento(string nome)
        {
            BLLEvento bEvento = new BLLEvento();
            return bEvento.ProcurarData(nome);
        }     
        public Evento PesquisarEvento(int id)
        {
            BLLEvento bEvento = new BLLEvento();
            return bEvento.ProcurarEvento(id);
        }
        public Evento PesquisarPreco(int id, string tipoIngresso)
        {
            BLLEvento bEvento = new BLLEvento();
            return bEvento.ProcurarPreco(id, tipoIngresso);
        }
        public void ExcluirEvento(Evento ev)
        {
            BLLEvento bEvento = new BLLEvento();
            bEvento.Excluir(ev);
        }
        

        // Cliente
        public Cliente PesquisarCliente(int id)
        {
            BLLCliente bCliente = new BLLCliente();
            return bCliente.PesquisarCliente(id);

        }
        public void NovoCliente(Cliente c)
        {
            BLLCliente bCliente = new BLLCliente();
            bCliente.Inserir(c);
        }
        public void ExcluirCliente(Cliente c)
        {
            BLLCliente bCliente = new BLLCliente();
            bCliente.Excluir(c);
        }
        public List<Cliente> ListarClientes()
        {
            BLLCliente bCliente = new BLLCliente();
            return bCliente.Listar();
        }


        // Atração
        public void NovaAtracao(Atracao a)
        {
            BLLAtracao bAtracao = new BLLAtracao();
            bAtracao.Inserir(a);
        }
        public Atracao PesquisarAtracao(int id)
        {
            BLLAtracao bAtracao = new BLLAtracao();
            return bAtracao.ProcurarEvento(id);
        }
        public List<Atracao> ListarAtracoes()
        {
            BLLAtracao bAtracao = new BLLAtracao();
            return bAtracao.Listar();
        }
        public void ExcluirAtracao(Atracao a)
        {
            BLLAtracao bAtracao = new BLLAtracao();
            bAtracao.Excluir(a);
        }


        // RitmoEvento
        public void NovoRitmoEvento(RitmoEvento re)
        {
            BLLRitmoEvento bRitmoEvento = new BLLRitmoEvento();
            bRitmoEvento.Inserir(re);
        }
        public RitmoEvento PesquisarRitmoEvento(int id)
        {
            BLLRitmoEvento bRitmoEvento = new BLLRitmoEvento();
            return bRitmoEvento.PesquisarRitmoEvento(id);
        }


        // Ritmo
        public void NovoRitmo(Ritmo r)
        {
            BLLRitmo bRitmo = new BLLRitmo();
            bRitmo.Inserir(r);
        }
        public Ritmo PesquisarRitmo(int id)
        {
            BLLRitmo bRitmo = new BLLRitmo();
            return bRitmo.PesquisarRitmo(id);
        }
        public List<Ritmo> ListarRitmos()
        {
            BLLRitmo bRitmo = new BLLRitmo();
            return bRitmo.Listar();
        }
        public void ExcluirRitmo(Ritmo r)
        {
            BLLRitmo bRitmo = new BLLRitmo();
            bRitmo.Excluir(r);
        }


        // Forma de Pagamento
        public void NovaFormaPagto(FormaPagto fp)
        {
            BLLFormaPagto bFPagto = new BLLFormaPagto();
            bFPagto.Inserir(fp);
        }
        public List<FormaPagto> ListarFormaPagto()
        {
            BLLFormaPagto bFPagto = new BLLFormaPagto();
            return bFPagto.Lista();
        }
        public FormaPagto PesquisarFormaPagtoID(string nome)
        {
            BLLFormaPagto bFormaPagto = new BLLFormaPagto();
            return bFormaPagto.PesquisarFormaPagto(nome);
        }
        public FormaPagto PesquisarFormaPagto(int id)
        {
            BLLFormaPagto bFormaPagto = new BLLFormaPagto();
            return bFormaPagto.PesquisarFormaPagto(id);
        }


        // Forma de Pagamento-Venda
        public List<FormaPagtoVenda> ListarFormaPagtoVenda()
        {
            BLLFormaPagtoVenda bFPV = new BLLFormaPagtoVenda();
            return bFPV.Lista();
        }

        public void NovaFormaPagtoVenda(FormaPagtoVenda fpv)
        {
            BLLFormaPagtoVenda bFPV = new BLLFormaPagtoVenda();
            bFPV.Inserir(fpv);
        }

        public FormaPagtoVenda PesquisarFormaPagtoVenda(int fpv)
        {
            BLLFormaPagtoVenda bFPV = new BLLFormaPagtoVenda();
            return bFPV.PesquisarFormaPagtoVenda(fpv);
        }
    }
}
