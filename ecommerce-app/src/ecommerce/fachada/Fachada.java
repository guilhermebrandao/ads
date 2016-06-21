package ecommerce.fachada;

import java.util.ArrayList;
import java.util.List;

import ecommerce.basicas.Cliente;
import ecommerce.basicas.Produto;
import ecommerce.negocio.RNCliente;
import ecommerce.negocio.RNProduto;

public class Fachada implements IFachada {

	// ------------- Métodos do PRODUTO --------------

	public void incluirProduto(Produto produto) {
		RNProduto rn = new RNProduto();
		rn.inserirValido(produto);
	}

	public List<Produto> listarProdutos() {
		RNProduto rn = new RNProduto();
		return rn.listar();
	}

	public void alterarProduto(Produto produto) {
		RNProduto rn = new RNProduto();
		rn.alterarValido(produto);
	}

	public void deletarProduto(Produto produto) {
		RNProduto rn = new RNProduto();
		rn.deletarValido(produto);
	}

	// ------------- Métodos do Cliente --------------

	public void incluirCliente(Cliente cliente) {
		RNCliente rn = new RNCliente();
		rn.inserirValido(cliente);
	}

	public void excluirCliente(Cliente cliente) {
		RNCliente rn = new RNCliente();
		rn.removerExistente(cliente);
	}
}
