package ecommerce.dados.dao;

import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.TypedQuery;

import com.sun.faces.mgbean.ManagedBeanPreProcessingException.Type;

import ecommerce.basicas.Produto;
import ecommerce.dados.dao.interfaces.IDAOProduto;
import ecommerce.dados.generico.DAOGenerico;

public class DAOProduto extends DAOGenerico<Produto> implements IDAOProduto {

	public DAOProduto(EntityManager em) {
		super(em);
	}

	public final Produto pesquisarPorNome(String nome) {
		Produto instance = null;
		try {
			instance = (Produto) getEntityManager().find(classePersistente, nome);
		} catch (RuntimeException re) {
			re.printStackTrace();
		}
		return instance;
	}
	
	public List<Produto> pesquisar(String nome){
		
		try {
			String sql = "from Produto p where lower(p.nome) LIKE lower(:nome)";
			TypedQuery<Produto> query = getEntityManager().createQuery(sql, Produto.class)
					.setParameter("nome", "%"+nome+"%");
			return query.getResultList();
		} catch (Exception e) {
			e.printStackTrace();
		}
		return null;
	}
}
