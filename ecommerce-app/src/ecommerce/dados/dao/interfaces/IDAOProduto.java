package ecommerce.dados.dao.interfaces;

import java.util.List;

import ecommerce.basicas.Produto;
import ecommerce.dados.generico.IDAOGenerico;

public interface IDAOProduto extends IDAOGenerico<Produto> {
	
	List<Produto> pesquisar(String nome);

	Produto pesquisarPorNome(String nome);

}
