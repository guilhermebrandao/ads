package ecommerce.dados.generico;

import java.lang.reflect.ParameterizedType;
import java.util.Collection;
import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.EntityTransaction;
import javax.persistence.TypedQuery;

public class DAOGenerico<T> implements IDAOGenerico<T> {

	protected EntityManager entityManager;
	protected Class<T> classePersistente;

	@SuppressWarnings("unchecked")
	public DAOGenerico(EntityManager em) {
		this.entityManager = em;
		ParameterizedType parameterizedType = (ParameterizedType) getClass()
				.getGenericSuperclass();
		classePersistente = (Class<T>) parameterizedType
				.getActualTypeArguments()[0];
	}

	/**
	 * Executa o merge do objeto que se encontra em memória.
	 * 
	 * @param objeto
	 *            a ser realizado o merge
	 * @return objeto que foi executado o merge
	 */
	public final void alterar(T objeto) {
		EntityTransaction tx = getEntityManager().getTransaction();
		try {
			tx.begin();

			objeto = getEntityManager().merge(objeto);

			tx.commit();

		} catch (Exception e) {
			e.printStackTrace();
			if (tx != null && tx.isActive()) {
				tx.rollback();
			}
		}
	}

	/**
	 * Salva o objeto atual na base de dados.
	 * 
	 * @param objeto
	 *            a ser salvo
	 */
	public final void inserir(T objeto) {
		EntityTransaction tx = getEntityManager().getTransaction();
		try {
			tx.begin();
			getEntityManager().persist(objeto);
			tx.commit();
			System.out.println(classePersistente.getSimpleName()
					+ " salvo com sucesso");
		} catch (Exception e) {
			e.printStackTrace();
			if (tx != null && tx.isActive()) {
				tx.rollback();
			}
		}
	}

	/**
	 * Salva o objeto atual na base de dados.
	 * 
	 * @param objeto
	 *            a ser salvo
	 */
	public final void inserirColecao(Collection<T> colecao) {
		EntityTransaction tx = getEntityManager().getTransaction();
		try {
			tx.begin();

			for (T entidade : colecao) {
				getEntityManager().persist(entidade);
			}

			tx.commit();

			System.out.println(classePersistente.getSimpleName()
					+ " salvos com sucesso: " + colecao.size());
		} catch (Exception e) {
			e.printStackTrace();
			if (tx != null && tx.isActive()) {
				tx.rollback();
			}
		}
	}

	/**
	 * Remove o objeto da base de dados.
	 * 
	 * @param objeto
	 *            a ser removido
	 */
	public final void remover(T objeto) {
		EntityTransaction tx = getEntityManager().getTransaction();
		try {
			tx.begin();

			objeto = getEntityManager().merge(objeto);
			getEntityManager().remove(objeto);

			tx.commit();

			System.out.println(classePersistente.getSimpleName()
					+ " removido com sucesso");
		} catch (Exception e) {
			e.printStackTrace();
			if (tx != null && tx.isActive()) {
				tx.rollback();
			}
		}
	}

	/**
	 * Busca o objeto uma vez passado sua chave como parâmetro.
	 * 
	 * @param chave
	 *            identificador
	 * @return Objeto do tipo T
	 */
	public final T pesquisarPorId(Integer chave) {
		T instance = null;
		try {
			instance = (T) getEntityManager().find(classePersistente, chave);
		} catch (RuntimeException re) {
			re.printStackTrace();
		}
		return instance;
	}

	public List<T> listarTodos() {
		try {
			String sql = "from " + classePersistente.getSimpleName();
			TypedQuery<T> query = entityManager.createQuery(sql,
					classePersistente);
			return query.getResultList();
		} catch (Exception e) {
			e.printStackTrace();
		}
		return null;
	}

	/**
	 * Utilizado para se injetar o Entity manager no DAO.
	 * 
	 * @param entityManager
	 *            entity manager
	 */
	public void setEntityManager(EntityManager entityManager) {
		this.entityManager = entityManager;
	}

	public EntityManager getEntityManager() {
		return entityManager;
	}


}
