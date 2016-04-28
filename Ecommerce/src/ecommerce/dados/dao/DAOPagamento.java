package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.Pagamento;
import ecommerce.dados.dao.interfaces.IDAOPagamento;
import ecommerce.dados.generico.DAOGenerico;

public class DAOPagamento extends DAOGenerico<Pagamento> implements IDAOPagamento {

	public DAOPagamento(EntityManager em) {
		super(em);
	}

}
