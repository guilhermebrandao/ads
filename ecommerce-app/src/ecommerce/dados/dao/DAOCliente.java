package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.Cliente;
import ecommerce.dados.dao.interfaces.IDAOCliente;

public class DAOCliente extends DAOUsuario<Cliente> implements IDAOCliente {

	public DAOCliente(EntityManager em) {
		super(em);
	}

}
