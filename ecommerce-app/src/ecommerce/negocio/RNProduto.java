package ecommerce.negocio;

import ecommerce.basicas.Produto;
import ecommerce.dados.dao.DAOProduto;
import ecommerce.dados.dao.interfaces.IDAOProduto;
import ecommerce.dados.generico.DAOFactory;
import ecommerce.negocio.interfaces.IRNProduto;

public class RNProduto implements IRNProduto {
	private IDAOProduto dao;
	public RNProduto() {
		dao = DAOFactory.getDAOProduto();
	}

	@Override
	public void inserir(Produto p) {
		

	}

	@Override
	public boolean verificaExistencia(Produto p) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean validaObjeto(Produto p) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean verificaNome(Produto p) {
		// TODO Auto-generated method stub
		return false;
	}

}
