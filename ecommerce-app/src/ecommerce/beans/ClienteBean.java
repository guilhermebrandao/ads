package ecommerce.beans;

import java.util.ArrayList;
import java.util.List;

import javax.faces.application.FacesMessage;
import javax.faces.bean.ManagedBean;
import javax.faces.context.FacesContext;

import ecommerce.basicas.Cliente;
import ecommerce.basicas.Endereco;
import ecommerce.basicas.Pedido;
import ecommerce.basicas.Produto;
import ecommerce.fachada.Fachada;

@ManagedBean
public class ClienteBean {
	private Cliente cliente;
	private Endereco endereco;
	private List<Endereco> enderecos;
	private List<Cliente> clientes;
	private Fachada fachada;
	private List<Pedido> pedidos;
	

	public ClienteBean() {
		cliente = new Cliente();
		endereco = new Endereco();
		enderecos = new ArrayList<Endereco>();
		clientes = new ArrayList<Cliente>();
		pedidos = new ArrayList<Pedido>();
		fachada = new Fachada();
	}


	public void cadastrarCliente() throws Exception {
		try {
			cliente.setEndereco(endereco);
			fachada.incluirCliente(cliente);
			cliente = new Cliente();
			FacesContext.getCurrentInstance().addMessage(null,
					new FacesMessage(FacesMessage.SEVERITY_INFO, "Informação: ", "Cadastro Realizado com Sucesso!"));
		} catch (Exception e) {
			FacesContext.getCurrentInstance().addMessage(null,
					new FacesMessage(FacesMessage.SEVERITY_ERROR, "Informação: ", e.getMessage()));
		}
			
		
	}

	/* GETTERS AND SETTERS */

	/**
	 * @return the cliente
	 */
	public Cliente getCliente() {
		return cliente;
	}


	/**
	 * @param cliente the cliente to set
	 */
	public void setCliente(Cliente cliente) {
		this.cliente = cliente;
	}


	/**
	 * @return the endereco
	 */
	public Endereco getEndereco() {
		return endereco;
	}


	/**
	 * @param endereco the endereco to set
	 */
	public void setEndereco(Endereco endereco) {
		this.endereco = endereco;
	}


	/**
	 * @return the enderecos
	 */
	public List<Endereco> getEnderecos() {
		return enderecos;
	}


	/**
	 * @param enderecos the enderecos to set
	 */
	public void setEnderecos(List<Endereco> enderecos) {
		this.enderecos = enderecos;
	}


	/**
	 * @return the clientes
	 */
	public List<Cliente> getClientes() {
		return clientes;
	}


	/**
	 * @param clientes the clientes to set
	 */
	public void setClientes(List<Cliente> clientes) {
		this.clientes = clientes;
	}


	/**
	 * @return the fachada
	 */
	public Fachada getFachada() {
		return fachada;
	}


	/**
	 * @param fachada the fachada to set
	 */
	public void setFachada(Fachada fachada) {
		this.fachada = fachada;
	}


	/**
	 * @return the pedidos
	 */
	public List<Pedido> getPedidos() {
		return pedidos;
	}


	/**
	 * @param pedidos the pedidos to set
	 */
	public void setPedidos(List<Pedido> pedidos) {
		this.pedidos = pedidos;
	}

}
