package ecommerce.basicas;

import java.util.Calendar;
import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name="TBPedido")
public class Pedido {
	
	@Id
	@GeneratedValue
	private int id;
	
	@ManyToOne
	private Cliente cliente;
	
	@Column(nullable=false)
	private Calendar dataPedido;
	
	@Column(nullable=false, length=10, columnDefinition="A Pagar")
	private String status;
	
	@OneToMany(mappedBy = "pedido", targetEntity = Pagamento.class, fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private List<Pagamento> pagamento;

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

	/**
	 * @return the pagamento
	 */
	public List<Pagamento> getPagamento() {
		return pagamento;
	}

	/**
	 * @param pagamento
	 *            the pagamento to set
	 */
	public void setPagamento(List<Pagamento> pagamento) {
		this.pagamento = pagamento;
	}
}
