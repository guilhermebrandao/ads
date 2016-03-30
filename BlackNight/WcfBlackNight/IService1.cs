using Biblioteca.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfBlackNight
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // Venda
        [OperationContract]
        void NovaVenda(Venda v);
        [OperationContract]
        List<Venda> ListarVendas();
        [OperationContract]
        Venda ProcurarId(int idCliente, int idEvento, DateTime dtEvento);
        [OperationContract]
        Venda PesquisarVenda(int id);

        // Cliente
        [OperationContract]
        void NovoCliente(Cliente c);
        [OperationContract]
        Cliente PesquisarCliente(int id);
        [OperationContract]
        List<Cliente> ListarClientes();
        [OperationContract]
        void ExcluirCliente(Cliente c);

        // Evento
        [OperationContract]
        void NovoEvento(Evento ev);
        [OperationContract]
        List<Evento> ListarEventos();
        [OperationContract]
        void ExcluirEvento(Evento ev);
        [OperationContract]
        Evento PesquisarEvento(int id);
        [OperationContract]
        Evento PesquisarPreco(int id, string tipoIngresso);
        [OperationContract]
        DateTime ListarHoraDoEvento(string nome);

        // Forma de Pagamento
        [OperationContract]
        void NovaFormaPagto(FormaPagto fp);
        [OperationContract]
        List<FormaPagto> ListarFormaPagto();
        [OperationContract]
        FormaPagto PesquisarFormaPagtoID(string nome);
        [OperationContract]
        FormaPagto PesquisarFormaPagto(int id);
  


        // Forma de Pagamento - Venda
        [OperationContract]
        void NovaFormaPagtoVenda(FormaPagtoVenda fpv);
        [OperationContract]
        List<FormaPagtoVenda> ListarFormaPagtoVenda();
        [OperationContract]
        FormaPagtoVenda PesquisarFormaPagtoVenda(int id); 

        // Atracao
        [OperationContract]
        void NovaAtracao(Atracao a);
        [OperationContract]
        Atracao PesquisarAtracao(int id);
        [OperationContract]
        List<Atracao> ListarAtracoes();
        void ExcluirAtracao(Atracao a);


        // Ritmo-Evento
        [OperationContract]
        void NovoRitmoEvento(RitmoEvento re);
        [OperationContract]
        RitmoEvento PesquisarRitmoEvento(int id);



        // Ritmo
        [OperationContract]
        void NovoRitmo(Ritmo r);
        [OperationContract]
        Ritmo PesquisarRitmo(int id);
        [OperationContract]
        List<Ritmo> ListarRitmos();
        [OperationContract]
        void ExcluirRitmo(Ritmo r);



        // TODO: Add your service operations here
    }


}
