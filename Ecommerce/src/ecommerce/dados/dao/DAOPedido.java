package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.Pedido;
import ecommerce.dados.dao.interfaces.IDAOPedido;
import ecommerce.dados.generico.DAOGenerico;

public class DAOPedido extends DAOGenerico<Pedido> implements IDAOPedido {

	public DAOPedido(EntityManager em) {
		super(em);
	}

}
