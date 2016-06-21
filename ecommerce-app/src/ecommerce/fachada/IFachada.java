package ecommerce.fachada;

import java.util.List;

import ecommerce.basicas.Cliente;
import ecommerce.basicas.Produto;
import ecommerce.negocio.RNProduto;

public interface IFachada {

	// ------------- M�todos do PRODUTO --------------

	public void incluirProduto(Produto produto);

	public List<Produto> listarProdutos();

	public void alterarProduto(Produto produto);

	public void deletarProduto(Produto produto);
	
	// ------------- M�todos do Cliente --------------

	public void incluirCliente(Cliente cliente);

	public void excluirCliente(Cliente cliente);
}
