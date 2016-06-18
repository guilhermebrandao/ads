package ecommerce.negocio;

public class RNFactory {

	/**
	 * Instancia de objeto do tipo RNAdministrador
	 * 
	 * @return Retorna uma nova instancia do objeto tipo RNAdministrador
	 */
	public static RNAdministrador getRNAdministrador() {
		return new RNAdministrador();
	}

	/**
	 * Instancia de objeto do tipo RNCliente
	 * 
	 * @return Retorna uma nova instancia do objeto tipo RNCliente
	 */
	public static RNCliente getRNCliente() {
		return new RNCliente();
	}

	/**
	 * Instancia de objeto do tipo RNEndereco
	 * 
	 * @return Retorna uma nova instancia do objeto tipo RNEndereco
	 */
	public static RNEndereco getRNEndereco() {
		return new RNEndereco();
	}

	/**
	 * Instancia de objeto do tipo RNPedido
	 * 
	 * @return Retorna uma nova instancia do objeto tipo RNPedido
	 */
	public static RNPedido getRNPedido() {
		return new RNPedido();
	}

	/**
	 * Instancia de objeto do tipo RNProduto
	 * 
	 * @return Retorna uma nova instancia do objeto tipo RNProduto
	 */
	public static RNProduto getRNProduto() {
		return new RNProduto();
	}
}
