package ecommerce.teste;

import java.util.ArrayList;

import ecommerce.basicas.Cliente;
import ecommerce.basicas.Endereco;
import ecommerce.basicas.UF;
import ecommerce.dados.dao.DAOCliente;
import ecommerce.dados.generico.DAOFactory;
import ecommerce.fachada.Fachada;

public class TesteInserir {

	public static void inserirColecaoCliente() {
		Cliente cliente;

		Endereco endereco = new Endereco();
		endereco.setBairro("bairro");
		endereco.setCidade("cidade");
		endereco.setLogradouro("logradouro");
		endereco.setNumero("174");
		endereco.setUf(UF.PE);

		ArrayList<Cliente> clientes = new ArrayList<>();
		for (int i = 0; i < 10; i++) {
			cliente = new Cliente();
			cliente.setSenha(i + " senha");
			cliente.setNome(i + " nome");
			cliente.setEmail(i + " email@email.com");
			cliente.setTelefone(i + " telefone");
			cliente.setTipoUsuario(i + " 2");
			cliente.setEndereco(endereco);
			cliente.setCartaoDeCredito("1234567812345678");

			clientes.add(cliente);
		}

		DAOCliente dao = DAOFactory.getDAOCliente();
		dao.inserirColecao(clientes);
	}

	public static void inserirCliente() {
		Fachada fachada = new Fachada();

		Cliente cliente = new Cliente();

		cliente.setSenha("senha");
		cliente.setNome("nome");
		cliente.setEmail("1email@email.com");
		cliente.setTelefone("telefone");
		cliente.setTipoUsuario("2");

		Endereco endereco = new Endereco();
		endereco.setBairro("bairro");
		endereco.setCidade("cidade");
		endereco.setLogradouro("logradouro");
		endereco.setNumero("174");
		endereco.setUf(UF.PE);

		cliente.setEndereco(endereco);
		cliente.setCartaoDeCredito("1234567812345678");

		fachada.incluirCliente(cliente);

	}

	public static void deletarCliente() {
		Cliente cliente = new Cliente();

		cliente.setId(6);

		DAOCliente dao = DAOFactory.getDAOCliente();
		dao.remover(cliente);
	}

	public static void pesquisarCliente() {
		DAOCliente dao = DAOFactory.getDAOCliente();
		Cliente cliente = dao.pesquisarPorId(7);

		System.out.println(cliente.getId() + " - "
				+ cliente.getCartaoDeCredito() + ", " + cliente.getEmail()
				+  ", " + cliente.getSenha() + ", "
				+ cliente.getTelefone() + ", "
				+ cliente.getEndereco().toString());
	}

	public static void testaRemoverFachada() {
		Cliente cliente = new Cliente();
		cliente.setEmail("3email@email.com");
		
		
		Fachada fachada = new Fachada();
		fachada.excluirCliente(cliente);
	}

	public static void main(String[] args) {
		inserirColecaoCliente();
	}
}
