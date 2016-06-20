package ecommerce.beans;

import java.io.Serializable;
import java.util.List;

import javax.faces.bean.ManagedBean;
import javax.faces.bean.ManagedProperty;
import javax.faces.bean.ViewScoped;

import ecommerce.basicas.Produto;
import ecommerce.fachada.Fachada;

@ManagedBean
@ViewScoped
public class ProdutoGridView implements Serializable {

	private List<Produto> produtos;
	
	private Produto produtoSelecionado;
	
	@ManagedProperty("#{produtoBean}")
	private ProdutoBean produtoBean;

	/**
	 * @return the produtos
	 */
	public List<Produto> getProdutos() {
		return produtos;
	}

	/**
	 * @param produtos the produtos to set
	 */
	public void setProdutos(List<Produto> produtos) {
		this.produtos = new Fachada().listarProdutos();
	}

	/**
	 * @return the produtoSelecionado
	 */
	public Produto getProdutoSelecionado() {
		return produtoSelecionado;
	}

	/**
	 * @param produtoSelecionado the produtoSelecionado to set
	 */
	public void setProdutoSelecionado(Produto produtoSelecionado) {
		this.produtoSelecionado = produtoSelecionado;
	}

	/**
	 * @return the produtoBean
	 */
	public ProdutoBean getProdutoBean() {
		return produtoBean;
	}

	/**
	 * @param produtoBean the produtoBean to set
	 */
	public void setProdutoBean(ProdutoBean produtoBean) {
		this.produtoBean = produtoBean;
	}
}

