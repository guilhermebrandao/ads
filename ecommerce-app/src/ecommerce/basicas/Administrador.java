package ecommerce.basicas;

import javax.persistence.Entity;
import javax.persistence.Table;

@Entity
@Table(name="TBAdministrador")
public class Administrador extends Usuario {
	public Administrador(){}
}
