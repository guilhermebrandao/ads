package ecommerce.dados.generico;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

import ecommerce.dados.dao.DAOAdministrador;
import ecommerce.dados.dao.DAOCarrinho;
import ecommerce.dados.dao.DAOCategoria;
import ecommerce.dados.dao.DAOCliente;
import ecommerce.dados.dao.DAOEndereco;
import ecommerce.dados.dao.DAOFornecedor;
import ecommerce.dados.dao.DAOItemCarrinho;
import ecommerce.dados.dao.DAOPagamento;
import ecommerce.dados.dao.DAOPedido;
import ecommerce.dados.dao.DAOProduto;

public class DAOFactory {
	private static EntityManager manager;
	private static final EntityManagerFactory factory;

	static {
		factory = Persistence.createEntityManagerFactory("testePSC");
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
	 * Método para retornar um objeto do tipo DAOCarrinho
	 * 
	 * @return um objeto do tipo DAOCarrinho;
	 */
	public static DAOCarrinho getDAOCarrinho() {
		DAOCarrinho dao = new DAOCarrinho(manager);
		return dao;
	}

	/***
	 * Método para retornar um objeto do tipo DAOCategoria
	 * 
	 * @return um objeto do tipo DAOCategoria;
	 */
	public static DAOCategoria getDAOCategoria() {
		DAOCategoria dao = new DAOCategoria(manager);
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
	 * Método para retornar um objeto do tipo DAOForcenedor
	 * 
	 * @return um objeto do tipo DAOFornecedor;
	 */
	public static DAOFornecedor getDAOFornecedor() {
		DAOFornecedor dao = new DAOFornecedor(manager);
		return dao;
	}

	/***
	 * Método para retornar um objeto do tipo DAOItemCarrinho
	 * 
	 * @return um objeto do tipo DAOItemCarrinho;
	 */
	public static DAOItemCarrinho getDAOItemCarrinho() {
		DAOItemCarrinho dao = new DAOItemCarrinho(manager);
		return dao;
	}

	/***
	 * Método para retornar um objeto do tipo DAOPagamento
	 * 
	 * @return um objeto do tipo DAOPagamento;
	 */
	public static DAOPagamento getDAOPagamento() {
		DAOPagamento dao = new DAOPagamento(manager);
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
