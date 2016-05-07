package ecommerce.negocio.interfaces;

import ecommerce.basicas.Produto;

public interface IRNProduto {

	public void inserirValido(Produto produto);
	
	public boolean verificaExistencia(Produto produto);

	public boolean validaObjeto(Produto produto);

}
