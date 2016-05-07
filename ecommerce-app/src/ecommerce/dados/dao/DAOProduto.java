package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.Produto;
import ecommerce.dados.dao.interfaces.IDAOProduto;
import ecommerce.dados.generico.DAOGenerico;

public class DAOProduto extends DAOGenerico<Produto> implements IDAOProduto {

	public DAOProduto(EntityManager em) {
		super(em);
	}

	public final Produto pesquisarPorNome(String nome) {
		Produto instance = null;
		try {
			instance = (Produto) getEntityManager().find(classePersistente, nome);
		} catch (RuntimeException re) {
			re.printStackTrace();
		}
		return instance;
	}
}
