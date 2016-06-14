package ecommerce.negocio.interfaces;

import ecommerce.basicas.Usuario;

public interface IRNUsuario {
	
	public boolean verificaExistencia(Class<Usuario> usuario);
	
	public boolean validaSenha(Class<Usuario> usuario);
}
