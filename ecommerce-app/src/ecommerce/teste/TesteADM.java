package ecommerce.teste;

import java.util.ArrayList;
import java.util.List;

import ecommerce.basicas.Administrador;
import ecommerce.dados.generico.DAOFactory;

public class TesteADM {

	public static void main(String[] args) {
		inserirColecaoADM();
	}

	private static void inserirColecaoADM() {
		Administrador administrador;

		List<Administrador> administradores = new ArrayList<Administrador>();
		for (int i = 1; i < 11; i++) {
			administrador = new Administrador();
			administrador.setEmail("admnistrador@email.com " + i);
			administrador.setNome("Nome Adm " + i);
			administrador.setSenha("senhaAdm " + i);
			administrador.setTipoUsuario("Adm " + i);

			administradores.add(administrador);
		}

		DAOFactory.getDAOAdministrador().inserirColecao(administradores);

	}
}
