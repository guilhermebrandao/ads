package ecommerce.basicas;

import java.util.Calendar;
import java.util.List;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.JoinTable;
import javax.persistence.ManyToMany;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name="TBPedido")
public class Pedido {
	
	public Pedido(){}
	
	/**
	 * @param cliente
	 * @param dataPedido
	 * @param status
	 * @param produtos
	 */
	public Pedido(Cliente cliente, Calendar dataPedido, String status,
			List<Produto> produtos) {
		super();
		this.cliente = cliente;
		this.dataPedido = dataPedido;
		this.status = status;
		this.produtos = produtos;
	}

	@Id
	@GeneratedValue
	private int id;
	
	@ManyToOne
	private Cliente cliente;
	
	@Column(nullable=false)
	private Calendar dataPedido;
	
	@Column(nullable=false, length=10)
	private String status;
	
	@ManyToMany(fetch = FetchType.EAGER)
	@JoinTable(name="TBPedidoProduto",
			   joinColumns=@JoinColumn(name="idPedido"),
			   inverseJoinColumns=@JoinColumn(name="idProduto"))
	private List<Produto> produtos;
	
	public List<Produto> getProdutos() {
		return produtos;
	}

	public void setProdutos(List<Produto> produtos) {
		this.produtos = produtos;
	}

	/**
	 * @return the id
	 */
	public int getId() {
		return id;
	}

	/**
	 * @param id
	 *            the id to set
	 */
	public void setId(int id) {
		this.id = id;
	}

	/**
	 * @return the cliente
	 */
	public Cliente getCliente() {
		return cliente;
	}

	/**
	 * @param cliente
	 *            the cliente to set
	 */
	public void setCliente(Cliente cliente) {
		this.cliente = cliente;
	}

	/**
	 * @return the dataPedido
	 */
	public Calendar getDataPedido() {
		return dataPedido;
	}

	/**
	 * @param dataPedido
	 *            the dataPedido to set
	 */
	public void setDataPedido(Calendar dataPedido) {
		this.dataPedido = dataPedido;
	}

	/**
	 * @return the status
	 */
	public String getStatus() {
		return status;
	}

	/**
	 * @param status
	 *            the status to set
	 */
	public void setStatus(String status) {
		this.status = status;
	}

}
