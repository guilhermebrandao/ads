package ecommerce.teste;

import ecommerce.dados.generico.DAOFactory;

public class TesteGeral {

	public static void main (String[] arg){
		System.out.println(DAOFactory.getDAOUsuario().getUsuario("email@email.com", "0 senha"));
	}
}
