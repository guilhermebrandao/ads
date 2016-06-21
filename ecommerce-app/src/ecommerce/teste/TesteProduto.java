package ecommerce.teste;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;

import ecommerce.basicas.Produto;
import ecommerce.dados.dao.DAOCliente;
import ecommerce.dados.generico.DAOFactory;
import ecommerce.fachada.Fachada;

public class TesteProduto {

	public static void main(String[] args) {
		testeSelect();
	}
	
	private static void testeSelect(){
		DAOCliente dao = DAOFactory.getDAOCliente();
		dao.getCliente("neto", "neto");
	}

	private static void inserirColecaoPedido() {
		Produto produto;
		List<Produto> produtos = new ArrayList<Produto>();
		
		for (int i = 0; i < 10; i++) {
			produto = new Produto("Produto Tal " + i, null, "Descricao Pa" + i, new BigDecimal(50.99), "985777593 " + i);
			produtos.add(produto);
		}
		
		DAOFactory.getDAOProduto().inserirColecao(produtos);
	}
	

	
	private static void listar(){
		Fachada fachada = new Fachada();
		
		for (Produto produto : fachada.listarProdutos()){
			System.out.println("\ncod barra : " + produto.getCodigoDeBarra() +
					"\nnome: " + produto.getNome() + 
					"\ndescricao: " + produto.getDescricao() + 
					"\npreco: " + produto.getPreco() + 
					"\nid: " + produto.getId() + "\n");
		}
	}
}
