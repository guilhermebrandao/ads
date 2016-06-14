package ecommerce.teste;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;

import ecommerce.basicas.Cliente;
import ecommerce.basicas.Endereco;
import ecommerce.basicas.Pedido;
import ecommerce.basicas.Produto;
import ecommerce.basicas.UF;
import ecommerce.dados.generico.DAOFactory;
import ecommerce.util.Datas;

public class TestePedido {

	public static void main(String[] args) {
		inserirPedido();
	}

	private static void inserirPedido() {

		Cliente cliente;

		Endereco endereco = new Endereco();
		endereco.setBairro("bairro");
		endereco.setCidade("cidade");
		endereco.setLogradouro("logradouro");
		endereco.setNumero("174");
		endereco.setUf(UF.PE);

		//'1', '0 email@email.com', '0 nome', '0 senha', '0 2', '1234567812345678', '0 telefone', '1'

		cliente = new Cliente();
		cliente.setId(1);
//		cliente.setSenha(" senha");
//		cliente.setNome(" nome");
//		cliente.setEmail(" email@email.com");
//		cliente.setTelefone(" telefone");
//		cliente.setTipoUsuario(" 2");
//		cliente.setEndereco(endereco);
//		cliente.setCartaoDeCredito("1234567812345678");
		
		Produto produto;
		List<Produto> produtos = new ArrayList<Produto>();
		
		for (int i = 2; i < 12; i++) {
			produto = new Produto();
			produto.setId(i);
			produtos.add(produto);
		}
		
		Pedido pedido = new Pedido(cliente, Calendar.getInstance(), "Pendente", produtos);
		
		DAOFactory.getDAOPedido().inserir(pedido);
	}
}
