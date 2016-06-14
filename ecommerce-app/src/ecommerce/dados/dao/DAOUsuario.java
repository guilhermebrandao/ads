package ecommerce.dados.dao;

import javax.persistence.EntityManager;

import ecommerce.basicas.Usuario;
import ecommerce.dados.dao.interfaces.IDAOUsuario;
import ecommerce.dados.generico.DAOGenerico;

public class DAOUsuario<T extends Usuario> extends DAOGenerico<T> implements IDAOUsuario<T> {

	public DAOUsuario(EntityManager em) {
		super(em);
	}


}
