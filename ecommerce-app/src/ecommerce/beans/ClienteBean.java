package ecommerce.beans;

import java.util.List;

import javax.faces.bean.ManagedBean;

import ecommerce.basicas.Cliente;
import ecommerce.fachada.Fachada;

@ManagedBean
public class ClienteBean {
	private Cliente cliente;
	private List<Cliente> clientes;
	private Fachada fachada;

	public ClienteBean() {
		// TODO Auto-generated constructor stub
	}

}
