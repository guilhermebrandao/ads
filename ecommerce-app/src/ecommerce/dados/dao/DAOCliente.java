package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.Cliente;
import ecommerce.dados.dao.interfaces.IDAOCliente;

public class DAOCliente extends DAOUsuario<Cliente> implements IDAOCliente {

	public DAOCliente(EntityManager em) {
		super(em);
	}

	@Override
	public final Cliente pesquisarPorEmail(String email) {
		Cliente instance = null;
		try {
			instance = (Cliente) getEntityManager().find(classePersistente, email);
		} catch (RuntimeException re) {
			re.printStackTrace();
		}
		return instance;
	}

	@Override
	public boolean verificaLogin(String login) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean verificaSenha(String senha) {
		// TODO Auto-generated method stub
		return false;
	}

}
