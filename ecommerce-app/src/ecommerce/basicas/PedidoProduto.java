package ecommerce.basicas;

import java.math.BigDecimal;

import javax.persistence.Column;
import javax.persistence.EmbeddedId;
import javax.persistence.Entity;
import javax.persistence.Table;

@Entity
@Table(name = "TBPedidoProduto")
public class PedidoProduto {

	@EmbeddedId
	private PedidoProdutoID chaveComposta;

	@Column(precision = 10, scale = 2)
	private BigDecimal preco;

	@Column
	private Integer quantidade;

	public PedidoProdutoID getChaveComposta() {
		return chaveComposta;
	}

	public void setChaveComposta(PedidoProdutoID chaveComposta) {
		this.chaveComposta = chaveComposta;
	}

	public BigDecimal getPreco() {
		return preco;
	}

	public void setPreco(BigDecimal preco) {
		this.preco = preco;
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
}
