package ecommerce.beans;

import java.util.ArrayList;
import java.util.List;

import javax.faces.application.FacesMessage;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;
import javax.faces.context.FacesContext;

import ecommerce.basicas.Pedido;
import ecommerce.basicas.Produto;
import ecommerce.fachada.Fachada;


@ManagedBean
@SessionScoped
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
			FacesContext.getCurrentInstance().addMessage(null,
					new FacesMessage(FacesMessage.SEVERITY_INFO, "Informação: ", "Cadastro Realizado com Sucesso!"));
		} catch (Exception e) {
			// TODO Auto-generated catch block
			FacesContext.getCurrentInstance().addMessage(null,
					new FacesMessage(FacesMessage.SEVERITY_ERROR, "Informação: ", e.getMessage()));
		}
	
	}
	public void edit() throws Exception {
		try {

			fachada.alterarProduto(produto);
			FacesContext.getCurrentInstance().addMessage(null,
					new FacesMessage(FacesMessage.SEVERITY_INFO, "Informação: ", "Alteração Realizada com Sucesso!"));
		} catch (Exception e) {
			// TODO Auto-generated catch block
			FacesContext.getCurrentInstance().addMessage(null,
					new FacesMessage(FacesMessage.SEVERITY_ERROR, "Informação: ", e.getMessage()));
		}

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
