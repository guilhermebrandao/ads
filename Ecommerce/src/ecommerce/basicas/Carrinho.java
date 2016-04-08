package ecommerce.basicas;

import java.util.Calendar;
import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name="TBCarrinho")
public class Carrinho {
	
	@Id
	@GeneratedValue
	private int id;
	
	@OneToMany(mappedBy = "carrinho", targetEntity = Produto.class, fetch = FetchType.EAGER, cascade = CascadeType.ALL)
	private List<Produto> produto;
	
	@Column(nullable=false)
	private Integer quantidade;
	
	@Column(nullable=false)
	private Calendar dataAdicionado;
	
	@OneToMany(mappedBy = "carrinho", targetEntity = ItemCarrinho.class, fetch = FetchType.LAZY, cascade = CascadeType.ALL)
	private List<ItemCarrinho> itemCarrinho;

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
	 * @return the produto
	 */
	public List<Produto> getProduto() {
		return produto;
	}

	/**
	 * @param produto
	 *            the produto to set
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
	 * @param quantidade
	 *            the quantidade to set
	 */
	public void setQuantidade(Integer quantidade) {
		this.quantidade = quantidade;
	}

	/**
	 * @return the dataAdicionado
	 */
	public Calendar getDataAdicionado() {
		return dataAdicionado;
	}

	/**
	 * @param dataAdicionado
	 *            the dataAdicionado to set
	 */
	public void setDataAdicionado(Calendar dataAdicionado) {
		this.dataAdicionado = dataAdicionado;
	}

	/**
	 * @return the itemCarrinho
	 */
	public List<ItemCarrinho> getItemCarrinho() {
		return itemCarrinho;
	}

	/**
	 * @param itemCarrinho
	 *            the itemCarrinho to set
	 */
	public void setItemCarrinho(List<ItemCarrinho> itemCarrinho) {
		this.itemCarrinho = itemCarrinho;
	}
}
