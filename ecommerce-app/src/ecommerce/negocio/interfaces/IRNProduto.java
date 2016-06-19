package ecommerce.negocio.interfaces;

import java.util.List;

import ecommerce.basicas.Produto;

public interface IRNProduto {

	void inserirValido(Produto produto);
	
	boolean verificaExistencia(Produto produto);

	boolean validaObjeto(Produto produto);

	List<Produto> listar();

}
