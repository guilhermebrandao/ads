package ecommerce.dados.generico;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

import ecommerce.dados.dao.DAOAdministrador;
import ecommerce.dados.dao.DAOCliente;
import ecommerce.dados.dao.DAOEndereco;
import ecommerce.dados.dao.DAOPedido;
import ecommerce.dados.dao.DAOProduto;

public class DAOFactory {
	private static EntityManager manager;
	private static final EntityManagerFactory factory;

	static {
		factory = Persistence.createEntityManagerFactory("ecommerce");
		if (manager == null || !manager.isOpen()) {
			manager = factory.createEntityManager();
		}
	}

	/***
	 * Método para retornar um objeto do tipo DAOAdministrador
	 * 
	 * @return um objeto do tipo DAOAdministrador
	 */
	public static DAOAdministrador getDAOAdministrador() {
		DAOAdministrador dao = new DAOAdministrador(manager);
		return dao;
	}


	/***
	 * Método para retornar um objeto do tipo DAOCliente
	 * 
	 * @return um objeto do tipo DAOCliente;
	 */
	public static DAOCliente getDAOCliente() {
		DAOCliente dao = new DAOCliente(manager);
		return dao;
	}

	/***
	 * Método para retornar um objeto do tipo DAOEndereco
	 * 
	 * @return um objeto do tipo DAOEndereco;
	 */
	public static DAOEndereco getDAOEndereco() {
		DAOEndereco dao = new DAOEndereco(manager);
		return dao;
	}

	/***
	 * Método para retornar um objeto do tipo DAOPedido
	 * 
	 * @return um objeto do tipo DAOPedido;
	 */
	public static DAOPedido getDAOPedido() {
		DAOPedido dao = new DAOPedido(manager);
		return dao;
	}

	/***
	 * Método para retornar um objeto do tipo DAOProduto
	 * 
	 * @return um objeto do tipo DAOProduto;
	 */
	public static DAOProduto getDAOProduto() {
		DAOProduto dao = new DAOProduto(manager);
		return dao;
	}
}
