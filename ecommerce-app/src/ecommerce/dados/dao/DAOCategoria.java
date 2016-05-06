package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.Categoria;
import ecommerce.dados.dao.interfaces.IDAOCategoria;
import ecommerce.dados.generico.DAOGenerico;

public class DAOCategoria extends DAOGenerico<Categoria> implements IDAOCategoria{

	public DAOCategoria(EntityManager em) {
		super(em);
	}

}
