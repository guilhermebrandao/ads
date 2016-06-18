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
		if (!verificaExistencia(cliente) && validaObjeto(cliente)) {
			try {
				dao.inserir(cliente);
			} catch (Exception e) {
				System.out.println("Erro ao tentar inserir novo cliente"
						+ e.getMessage());
			}
		}

	}

//	@Override
//	public boolean verificaExistencia(Cliente cliente) {
//		if (dao.pesquisarPorEmail(cliente.getEmail()) != null) {
//			return true;
//		}
//		return false;
//	}

	@Override
	public boolean validaObjeto(Cliente cliente) {
		if (cliente.getEndereco() != null) {
			return true;
		} else if (cliente.getTelefone() != null) {
			return true;
		} else if (cliente.getSenha() != null) {
			return true;
		} else if (cliente.getEmail() != null) {
			return true;
		} else if (cliente.getNome() != null) {
			return true;
		} else {
			return false;
		}

	}

	@Override
	public boolean verficaLoginSenha(String login, String senha) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public void removerExistente(Cliente cliente) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public boolean verificaExistencia(Cliente cliente) {
		// TODO Auto-generated method stub
		return false;
	}

//	@Override
//	public void removerExistente(Cliente cliente) {
//		if (verificaExistencia(cliente)){
//			Cliente clienteExcl = dao.pesquisarPorEmail(cliente.getEmail());
//			dao.remover(clienteExcl);
//			System.out.println("Cliente excluído com sucesso.");
//		} else {
//			System.out.println("Não foi possível excluir o cliente.");
//		}
		
//	}
	
	

}