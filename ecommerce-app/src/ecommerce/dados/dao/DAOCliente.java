package ecommerce.dados.dao;

import javax.management.Query;
import javax.persistence.EntityManager;
import javax.persistence.TypedQuery;

import ecommerce.basicas.Cliente;
import ecommerce.dados.dao.interfaces.IDAOCliente;

public class DAOCliente extends DAOUsuario<Cliente> implements IDAOCliente {

	public DAOCliente(EntityManager em) {
		super(em);
	}

//	@Override
//	public Cliente pesquisarPorEmail(String email) {
//		Cliente instance = null;
//		try {
//			String consulta = "Select c from Cliente c WHERE c.email = :email";
//			TypedQuery<Cliente> query = getEntityManager().createQuery(consulta, Cliente.class);
//			query.setParameter("email", email);
//			instance = query.getSingleResult();
//		} catch (RuntimeException re) {
//			re.printStackTrace();
//		}
//		return instance;
//	}

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
