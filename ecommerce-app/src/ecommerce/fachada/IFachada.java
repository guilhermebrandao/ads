package ecommerce.fachada;

import ecommerce.basicas.Cliente;
import ecommerce.basicas.Produto;

public interface IFachada {

	// ------------- M�todos do PRODUTO --------------

	public void incluirProduto(Produto produto);

	public void alterarProduto(Produto produto);
	// ------------- M�todos do Cliente --------------

	public void incluirCliente(Cliente cliente);

	public void excluirCliente(Cliente cliente);
}
