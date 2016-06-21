package ecommerce.beans;

import java.util.ArrayList;
import java.util.List;

import javax.faces.application.FacesMessage;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.NoneScoped;
import javax.faces.bean.SessionScoped;
import javax.faces.bean.ViewScoped;
import javax.faces.context.FacesContext;

import org.primefaces.event.RowEditEvent;

import ecommerce.basicas.Produto;
import ecommerce.fachada.Fachada;

@ManagedBean(name = "produtoBean")
@ViewScoped
public class ProdutoBean {

	private Fachada fachada;
	private Produto produto;
	private List<Produto> produtos;

	public ProdutoBean() {
		this.fachada = new Fachada();
		this.produto = new Produto();
		this.produtos = new ArrayList<Produto>();
	}

	public void clear() {

		produto.setCodigoDeBarra(null);
		produto.setNome(null);
		produto.setDescricao(null);
		produto.setPreco(null);
		produto = new Produto();
	}

	public void cadastrarProduto() throws Exception {
		try {
			fachada.incluirProduto(produto);
			produto = new Produto();
			FacesContext.getCurrentInstance().addMessage(null,
					new FacesMessage(FacesMessage.SEVERITY_INFO, "Informa��o: ", "Cadastro Realizado com Sucesso!"));
		} catch (Exception e) {
			FacesContext.getCurrentInstance().addMessage(null,
					new FacesMessage(FacesMessage.SEVERITY_ERROR, "Informa��o: ", e.getMessage()));
		}

	}

	public void editarProduto() throws Exception {
		try {
			fachada.alterarProduto(produto);
			FacesContext.getCurrentInstance().addMessage(null,
					new FacesMessage(FacesMessage.SEVERITY_INFO, "Informa��o: ", "Altera��o Realizada com Sucesso!"));
		} catch (Exception e) {
			FacesContext.getCurrentInstance().addMessage(null,
					new FacesMessage(FacesMessage.SEVERITY_ERROR, "Informa��o: ", e.getMessage()));
		}

	}

	public void onRowEdit(RowEditEvent event) {
		// FacesMessage msg = new FacesMessage("Produto Editado", ((Produto)
		// event.getObject()).getId().toString());

		produto = ((Produto) event.getObject());
		fachada.alterarProduto(produto);
		FacesContext.getCurrentInstance().addMessage(null,
				new FacesMessage(FacesMessage.SEVERITY_INFO, "Informa��o: ", "Altera��o Realizada com Sucesso!"));
		// FacesContext.getCurrentInstance().addMessage(null, msg);
	}

	public void onRowCancel(RowEditEvent event) {
		FacesMessage msg = new FacesMessage("Edi��o Cancelada", ((Produto) event.getObject()).getId().toString());
		FacesContext.getCurrentInstance().addMessage(null, msg);
	}

	public void removerProdutos(Integer indice) {
		produtos.remove(indice);
	}

	public Fachada getFachada() {
		return fachada;
	}

	public void setFachada(Fachada fachada) {
		this.fachada = fachada;
	}

	public Produto getProduto() {
		return produto;
	}

	public void setProduto(Produto produto) {
		this.produto = produto;
	}

	public List<Produto> getProdutos() {
		return produtos = fachada.listarProdutos();
	}

	public void setProdutos(List<Produto> produtos) {
		this.produtos = produtos;
	}
}
