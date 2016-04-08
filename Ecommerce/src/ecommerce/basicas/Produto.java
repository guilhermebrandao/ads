package ecommerce.basicas;

import java.math.BigDecimal;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name="TBProduto")
public class Produto {
	
	@Id
	@GeneratedValue
	private int id;
	
	@Column(nullable = false, length=50)
	private String nome;
	
	@ManyToOne
	private Categoria categoria;
	
	@ManyToOne
	private Carrinho carrinho;
	
	@ManyToOne
	private Fornecedor fornecedor;
	
	@Column(nullable = false, length=300)
	private String descricao;
	
	@Column(precision=10, scale=2)
	private BigDecimal preco;
	
	@Column(nullable=false)
	private String carrinhoImagem;
	
	@Column(nullable=false)
	private String codigoDeBarra;
	
	@ManyToOne
	private ItemCarrinho itemCarrinho;

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
	 * @return the categoria
	 */
	public Categoria getCategoria() {
		return categoria;
	}

	/**
	 * @param categoria
	 *            the categoria to set
	 */
	public void setCategoria(Categoria categoria) {
		this.categoria = categoria;
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
	 * @return the carrinhoImagem
	 */
	public String getCarrinhoImagem() {
		return carrinhoImagem;
	}

	/**
	 * @param carrinhoImagem
	 *            the carrinhoImagem to set
	 */
	public void setCarrinhoImagem(String carrinhoImagem) {
		this.carrinhoImagem = carrinhoImagem;
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

	/**
	 * @return the fornecedor
	 */
	public Fornecedor getFornecedor() {
		return fornecedor;
	}

	/**
	 * @param fornecedor the fornecedor to set
	 */
	public void setFornecedor(Fornecedor fornecedor) {
		this.fornecedor = fornecedor;
	}

	/**
	 * @return the itemCarrinho
	 */
	public ItemCarrinho getItemCarrinho() {
		return itemCarrinho;
	}

	/**
	 * @param itemCarrinho the itemCarrinho to set
	 */
	public void setItemCarrinho(ItemCarrinho itemCarrinho) {
		this.itemCarrinho = itemCarrinho;
	}
}
