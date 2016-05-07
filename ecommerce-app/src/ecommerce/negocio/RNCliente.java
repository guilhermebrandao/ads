package ecommerce.negocio;

import ecommerce.basicas.Cliente;
import ecommerce.dados.dao.interfaces.IDAOCliente;
import ecommerce.dados.generico.DAOFactory;
import ecommerce.negocio.interfaces.IRNCliente;

public class RNCliente implements IRNCliente {

	private IDAOCliente dao;

	public RNCliente() {
		dao = DAOFactory.getDAOCliente();
	}

	@Override
	public void inserirValido(Cliente cliente) {
		if(verificaExistencia(cliente) && validaObjeto(cliente)){
			try {
				dao.inserir(cliente);
			} catch (Exception e) {
				System.out.println("Erro ao tentar inserir novo cliente" + e.getMessage());
			}
		}

	}

	@Override
	public boolean verificaExistencia(Cliente cliente) {
		if (dao.pesquisarPorNome(cliente.getNome()) == null) {
			return true;
		}
		return false;
	}

	@Override
	public boolean validaObjeto(Cliente cliente) {
		if (cliente.getEndereco() != null) {
			return true;
		} else if (cliente.getTelefone() != null) {
			return true;
		} else if (cliente.getLogin() != null) {
			return true;
		} else if (cliente.getSenha() != null) {
			return true;
		} else if (cliente.getTipoUsuario() != null) {
			return true;
		} else {
			return false;
		}

	}

}
