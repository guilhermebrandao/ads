package ecommerce.basicas;

import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.OneToMany;
import javax.persistence.OneToOne;
import javax.persistence.Table;

@Entity
@Table(name="TBCliente")
public class Cliente extends Usuario {

	public Cliente(){}
	
	@Column(nullable = false, length=11) // Formato 81988887777
	private String telefone;
	
	@Column(nullable=false, length=16)
	private String cartaoDeCredito;
	
	@OneToOne(fetch=FetchType.LAZY, cascade=CascadeType.ALL)
	private Endereco endereco;
	
	@OneToMany(mappedBy = "cliente", targetEntity = Pedido.class, fetch = FetchType.LAZY, cascade = CascadeType.ALL)
	private List<Pedido> pedidos;

	/**
	 * @return the telefone
	 */
	public String getTelefone() {
		return telefone;
	}
	/**
	 * @param telefone the telefone to set
	 */
	public void setTelefone(String telefone) {
		this.telefone = telefone;
	}
	/**
	 * @return the cartaoDeCredito
	 */
	public String getCartaoDeCredito() {
		return cartaoDeCredito;
	}
	/**
	 * @param cartaoDeCredito the cartaoDeCredito to set
	 */
	public void setCartaoDeCredito(String cartaoDeCredito) {
		this.cartaoDeCredito = cartaoDeCredito;
	}
	/**
	 * @return the endereco
	 */
	public Endereco getEndereco() {
		return endereco;
	}
	/**
	 * @param endereco the endereco to set
	 */
	public void setEndereco(Endereco endereco) {
		this.endereco = endereco;
	}

	/**
	 * @return the pedido
	 */
	public List<Pedido> getPedido() {
		return pedidos;
	}
	/**
	 * @param pedido the pedido to set
	 */
	public void setPedido(List<Pedido> pedido) {
		this.pedidos = pedido;
	}
	
}
