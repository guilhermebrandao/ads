package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.Fornecedor;
import ecommerce.dados.dao.interfaces.IDAOFornecedor;
import ecommerce.dados.generico.DAOGenerico;

public class DAOFornecedor extends DAOGenerico<Fornecedor> implements IDAOFornecedor {

	public DAOFornecedor(EntityManager em) {
		super(em);
	}

}
