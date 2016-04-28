package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.Produto;
import ecommerce.dados.dao.interfaces.IDAOProduto;
import ecommerce.dados.generico.DAOGenerico;

public class DAOProduto extends DAOGenerico<Produto> implements IDAOProduto {

	public DAOProduto(EntityManager em) {
		super(em);
	}

}
