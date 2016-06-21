package ecommerce.beans;

	 import java.io.Serializable;

import javax.faces.application.FacesMessage;
	  import javax.faces.bean.ManagedBean;
	  import javax.faces.bean.ViewScoped;
	  import javax.faces.context.FacesContext;
	  import ecommerce.basicas.Cliente;
import ecommerce.dados.dao.DAOCliente;
import ecommerce.dados.generico.DAOFactory;
	
	   
	  @ManagedBean(name = "LoginMB")
	  @ViewScoped
	  public class LoginManagedBean implements Serializable {
	   
		  	private static final long serialVersionUID = 1L;
	        private DAOCliente usuarioDAO = DAOFactory.getDAOCliente();
	        private Cliente cliente = new Cliente();
	        
	        public String envia() {
	              
	              cliente = usuarioDAO.getCliente(cliente.getEmail(), cliente.getSenha());
	              if (cliente == null) {
	                    cliente = new Cliente();
	                    FacesContext.getCurrentInstance().addMessage(
	                               null,
	                               new FacesMessage(FacesMessage.SEVERITY_ERROR, "Usuário não encontrado!",
	                                           "Erro no Login!"));
	                    return null;
	              } else {
	                    return "/index";
	              }
	              
	         
	              
	        }
	   
	        public Cliente getCliente() {
	              return cliente;
	        }
	   
	        public void setCliente(Cliente cliente) {
	              this.cliente = cliente;
	        }
	  }

