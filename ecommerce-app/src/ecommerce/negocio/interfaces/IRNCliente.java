package ecommerce.negocio.interfaces;

import ecommerce.basicas.Cliente;



public interface IRNCliente {

	public void inserirValido(Cliente cliente);
	
	public boolean verificaExistencia(Cliente cliente);

	public boolean validaObjeto(Cliente cliente);

}
