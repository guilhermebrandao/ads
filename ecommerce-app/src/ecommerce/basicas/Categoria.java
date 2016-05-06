package ecommerce.basicas;

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
@Table(name = "TBCategoria")
public class Categoria {

	@Id
	@GeneratedValue
	private int id;

	@Column(nullable = false, length = 20)
	private String nome;

	@Column(nullable=false, length = 80)
	private String descricao;
	
	@OneToMany(mappedBy = "categoria", targetEntity = Produto.class, fetch = FetchType.LAZY, cascade = CascadeType.ALL)
	private List<Produto> produtos;

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
	 * @return the produto
	 */
	public List<Produto> getProduto() {
		return produtos;
	}

	/**
	 * @param produto
	 *            the produto to set
	 */
	public void setProduto(List<Produto> produto) {
		this.produtos = produto;
	}
}
