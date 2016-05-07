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

	public static DAOAdministrador getDAOAdministrador() {
		DAOAdministrador dao = new DAOAdministrador(manager);
		return dao;
	}

	public static DAOCarrinho getDAOCarrinho() {
		DAOCarrinho dao = new DAOCarrinho(manager);
		return dao;
	}

	public static DAOCategoria getDAOCategoria() {
		DAOCategoria dao = new DAOCategoria(manager);
		return dao;
	}

	public static DAOCliente getDAOCliente() {
		DAOCliente dao = new DAOCliente(manager);
		return dao;

	}

	public static DAOEndereco getDAOEndereco() {
		DAOEndereco dao = new DAOEndereco(manager);
		return dao;
	}

	public static DAOFornecedor getDAOFornecedor() {
		DAOFornecedor dao = new DAOFornecedor(manager);
		return dao;
	}

	public static DAOItemCarrinho getDAOItemCarrinho() {
		DAOItemCarrinho dao = new DAOItemCarrinho(manager);
		return dao;
	}

	public static DAOPagamento getDAOPagamento() {
		DAOPagamento dao = new DAOPagamento(manager);
		return dao;
	}

	public static DAOPedido getDAOPedido() {
		DAOPedido dao = new DAOPedido(manager);
		return dao;
	}

	public static DAOProduto getDAOProduto() {
		DAOProduto dao = new DAOProduto(manager);
		return dao;
	}
}
