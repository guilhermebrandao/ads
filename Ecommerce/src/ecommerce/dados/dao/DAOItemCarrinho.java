package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.ItemCarrinho;
import ecommerce.dados.dao.interfaces.IDAOItemCarrinho;
import ecommerce.dados.generico.DAOGenerico;

public class DAOItemCarrinho extends DAOGenerico<ItemCarrinho> implements IDAOItemCarrinho{

	public DAOItemCarrinho(EntityManager em) {
		super(em);
	}

}
