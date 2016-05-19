package ecommerce.teste;

import ecommerce.basicas.Cliente;
import ecommerce.basicas.Endereco;
import ecommerce.basicas.UF;
import ecommerce.dados.dao.DAOCliente;
import ecommerce.dados.generico.DAOFactory;
import ecommerce.fachada.Fachada;

public class TesteInserir {

	public static void main(String[] args) {
		Fachada fachada = new Fachada();

		Cliente cliente = new Cliente();

		cliente.setLogin("login");
		cliente.setSenha("senha");
		cliente.setNome("nome");
		cliente.setEmail("email@email.com");
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

		DAOCliente dao = DAOFactory.getDAOCliente();
		dao.inserir(cliente);

	}

}
