package ecommerce.dados.dao.interfaces;

import ecommerce.basicas.Cliente;

public interface IDAOCliente extends IDAOUsuario<Cliente> {
	
	
	public boolean verificaLogin(String login);
	
	public boolean verificaSenha(String senha);
}
