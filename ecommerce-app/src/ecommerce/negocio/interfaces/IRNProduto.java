package ecommerce.negocio.interfaces;

import ecommerce.basicas.Produto;

public interface IRNProduto {
	public void inserir(Produto p);

	public boolean verificaExistencia(Produto p);

	public boolean validaObjeto(Produto p);

	public boolean verificaNome(Produto p);
}
