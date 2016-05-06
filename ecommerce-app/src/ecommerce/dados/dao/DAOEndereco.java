package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.Endereco;
import ecommerce.dados.dao.interfaces.IDAOEndereco;
import ecommerce.dados.generico.DAOGenerico;

public class DAOEndereco extends DAOGenerico<Endereco> implements IDAOEndereco {

	public DAOEndereco(EntityManager em) {
		super(em);
	}

}
