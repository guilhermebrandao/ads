package ecommerce.dados.dao.interfaces;

import ecommerce.basicas.Produto;
import ecommerce.dados.generico.IDAOGenerico;

public interface IDAOProduto extends IDAOGenerico<Produto> {
	
	public Produto pesquisarPorNome(String nome);
}
