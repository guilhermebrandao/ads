package ecommerce.dados.generico;

import java.util.List;

public interface IDAOGenerico<T> {

	public void inserir(T obj);
	
	public void alterar(T obj);
	
	public void remover(T obj);
	
	public T pesquisarPorId(Integer id);
	
	public List<T> listarTodos();
	
}
