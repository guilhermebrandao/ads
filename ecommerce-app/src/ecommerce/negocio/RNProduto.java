package ecommerce.negocio;

import ecommerce.basicas.Produto;
import ecommerce.dados.dao.interfaces.IDAOProduto;
import ecommerce.dados.generico.DAOFactory;
import ecommerce.negocio.interfaces.IRNProduto;

public class RNProduto implements IRNProduto {
	private IDAOProduto dao;

	public RNProduto() {
		dao = DAOFactory.getDAOProduto();
	}

	/***
	 * Antes de adicionar ao banco, o método verifica se objeto já existe no
	 * banco e se todos os campos obrigatórios estão preenchidos.
	 * 
	 * @param p
	 *            Objeto do tipo Produto a ser adicionado ao banco de dados.
	 */
	public void inserirValido(Produto p) {
		if (validaObjeto(p) && verificaExistencia(p)) {
			try {
				dao.inserir(p);
				System.out.println("Produto adicionado com sucesso!");
			} catch (Exception e) {
				System.out.println("Erro ao tentar adicionar produto"
						+ e.getMessage());
			}
		}
	}

	/***
	 * Retorna verdadeiro se todos os campos obrigatórios estivirem preenchidos
	 */
	@Override
	public boolean validaObjeto(Produto p) {

		if (p.getCodigoDeBarra() != null) {
			return true;
		} else if (p.getDescricao() != null) {
			return true;
		} else if (p.getId() != 0) {
			return true;
		} else if (p.getNome() != null) {
			return true;
		} else if (p.getPreco() != null) {
			return true;
		} else {
			return false;
		}
	}

	/***
	 * Retorna verdadeiro se o nome pesquisado não for encontrado
	 */
	@Override
	public boolean verificaExistencia(Produto p) {
		if (dao.pesquisarPorNome(p.getNome()) == null) {
			return true;
		}
		return false;
	}

}
