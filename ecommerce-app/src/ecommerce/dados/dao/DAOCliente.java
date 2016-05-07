package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.Cliente;
import ecommerce.dados.dao.interfaces.IDAOCliente;

public class DAOCliente extends DAOUsuario<Cliente> implements IDAOCliente {

	public DAOCliente(EntityManager em) {
		super(em);
	}

	@Override
	public final Cliente pesquisarPorNome(String nome) {
		Cliente instance = null;
		try {
			instance = (Cliente) getEntityManager().find(classePersistente, nome);
		} catch (RuntimeException re) {
			re.printStackTrace();
		}
		return instance;
	}

}
