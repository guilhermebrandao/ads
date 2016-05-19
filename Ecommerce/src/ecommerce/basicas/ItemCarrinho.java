package ecommerce.basicas;

import java.math.BigDecimal;
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
@Table(name="TBItemCarrinho")
public class ItemCarrinho {
	
	@Id
	@GeneratedValue
	private int id;
	
	@Column(nullable=false, length=30)
	private String nome;
	
	@OneToMany(mappedBy = "itemCarrinho", targetEntity = Produto.class, fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private List<Produto> produto;
	
	@Column(nullable=false)
	private Integer quantidade;
	
	@Column(precision=10, scale =2)
	private BigDecimal precoUnitario;
	
	@ManyToOne (fetch=FetchType.LAZY, cascade=CascadeType.ALL)
	private Carrinho carrinho;
	
	/**
	 * @return the id
	 */
	public int getId() {
		return id;
	}
	/**
	 * @param id the id to set
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
	 * @param nome the nome to set
	 */
	public void setNome(String nome) {
		this.nome = nome;
	}
	/**
	 * @return the produto
	 */
	public List<Produto> getProduto() {
		return produto;
	}
	/**
	 * @param produto the produto to set
	 */
	public void setProduto(List<Produto> produto) {
		this.produto = produto;
	}
	/**
	 * @return the quantidade
	 */
	public Integer getQuantidade() {
		return quantidade;
	}
	/**
	 * @param quantidade the quantidade to set
	 */
	public void setQuantidade(Integer quantidade) {
		this.quantidade = quantidade;
	}
	/**
	 * @return the precoUnitario
	 */
	public BigDecimal getPrecoUnitario() {
		return precoUnitario;
	}
	/**
	 * @param precoUnitario the precoUnitario to set
	 */
	public void setPrecoUnitario(BigDecimal precoUnitario) {
		this.precoUnitario = precoUnitario;
	}
	/**
	 * @return the carrinho
	 */
	public Carrinho getCarrinho() {
		return carrinho;
	}
	/**
	 * @param carrinho the carrinho to set
	 */
	public void setCarrinho(Carrinho carrinho) {
		this.carrinho = carrinho;
	}
}
