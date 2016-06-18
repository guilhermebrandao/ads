package ecommerce.basicas;

import java.math.BigDecimal;
import java.util.List;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.JoinTable;
import javax.persistence.ManyToMany;
import javax.persistence.Table;

@Entity
@Table(name="TBProduto")
public class Produto {
	
	public Produto(){}
	
	
	
	/**
	 * @param nome
	 * @param pedidos
	 * @param descricao
	 * @param preco
	 * @param codigoDeBarra
	 */
	public Produto(String nome, List<Pedido> pedidos, String descricao,
			BigDecimal preco, String codigoDeBarra) {
		super();
		this.nome = nome;
		this.pedidos = pedidos;
		this.descricao = descricao;
		this.preco = preco;
		this.codigoDeBarra = codigoDeBarra;
	}



	@Id
	@GeneratedValue
	private int id;
	
	@Column(nullable = false, length=50)
	private String nome;
	
	@ManyToMany(fetch = FetchType.LAZY)
	@JoinTable(name="TBPedidoProduto",
			   joinColumns=@JoinColumn(name="idProduto"),
			   inverseJoinColumns=@JoinColumn(name="idPedido"))
	private List<Pedido> pedidos;
	
	@Column(nullable = false, length=300)
	private String descricao;
	
	@Column(precision=10, scale=2)
	private BigDecimal preco;
	
	@Column(nullable=false)
	private String codigoDeBarra;
	

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
	 * @return the nome
	 */
	public String getNome() {
		return nome;
	}

	/**
	 * @param nome
	 *            the nome to set
	 */
	public void setNome(String nome) {
		this.nome = nome;
	}


	/**
	 * @return the descricao
	 */
	public String getDescricao() {
		return descricao;
	}

	/**
	 * @param descricao
	 *            the descricao to set
	 */
	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}

	/**
	 * @return the preco
	 */
	public BigDecimal getPreco() {
		return preco;
	}

	/**
	 * @param preco
	 *            the preco to set
	 */
	public void setPreco(BigDecimal preco) {
		this.preco = preco;
	}

	/**
	 * @return the codigoDeBarra
	 */
	public String getCodigoDeBarra() {
		return codigoDeBarra;
	}

	/**
	 * @param codigoDeBarra
	 *            the codigoDeBarra to set
	 */
	public void setCodigoDeBarra(String codigoDeBarra) {
		this.codigoDeBarra = codigoDeBarra;
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
