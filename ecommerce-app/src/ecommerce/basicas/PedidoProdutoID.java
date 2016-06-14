package ecommerce.basicas;

import java.io.Serializable;

import javax.persistence.Embeddable;
import javax.persistence.FetchType;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;

@Embeddable
public class PedidoProdutoID implements Serializable {

	@ManyToOne(fetch = FetchType.EAGER)
	@JoinColumn(name = "idPedido")
	private Pedido pedido;

	@ManyToOne
	@JoinColumn(name = "idProduto")
	private Produto produto;

	public Pedido getPedido() {
		return pedido;
	}

	public void setPedido(Pedido pedido) {
		this.pedido = pedido;
	}

	public Produto getProduto() {
		return produto;
	}

	public void setProduto(Produto produto) {
		this.produto = produto;
	}

}
