package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.Carrinho;
import ecommerce.dados.dao.interfaces.IDAOCarrinho;
import ecommerce.dados.generico.DAOGenerico;

public class DAOCarrinho extends DAOGenerico<Carrinho> implements IDAOCarrinho {

	public DAOCarrinho(EntityManager em) {
		super(em);

	}

}
