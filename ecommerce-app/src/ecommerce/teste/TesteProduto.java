package ecommerce.teste;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;

import ecommerce.basicas.Produto;
import ecommerce.dados.generico.DAOFactory;

public class TesteProduto {

	public static void main(String[] args) {
		inserirColecaoPedido();
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
}
