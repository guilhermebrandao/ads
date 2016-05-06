package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.Administrador;
import ecommerce.dados.dao.interfaces.IDAOAdministrador;

public class DAOAdministrador extends DAOUsuario<Administrador> implements IDAOAdministrador{

	public DAOAdministrador(EntityManager em) {
		super(em);
	}

}
