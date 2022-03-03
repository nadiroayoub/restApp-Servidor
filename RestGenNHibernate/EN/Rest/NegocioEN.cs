
using System;
// Definición clase NegocioEN
namespace RestGenNHibernate.EN.Rest
{
public partial class NegocioEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo direccion
 */
private string direccion;



/**
 *	Atributo ciudad
 */
private string ciudad;



/**
 *	Atributo cp
 */
private string cp;



/**
 *	Atributo provincia
 */
private string provincia;



/**
 *	Atributo pais
 */
private string pais;



/**
 *	Atributo servicios
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ServicioEN> servicios;



/**
 *	Atributo empleado
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.EmpleadoEN> empleado;



/**
 *	Atributo empresa
 */
private RestGenNHibernate.EN.Rest.EmpresaEN empresa;



/**
 *	Atributo mesa
 */
private RestGenNHibernate.EN.Rest.MesaEN mesa;



/**
 *	Atributo ingrediente
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.IngredienteEN> ingrediente;



/**
 *	Atributo caja
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.CajaEN> caja;



/**
 *	Atributo movimiento
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.MovimientoEN> movimiento;



/**
 *	Atributo pedidoProveedor
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoProveedorEN> pedidoProveedor;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}



public virtual string Ciudad {
        get { return ciudad; } set { ciudad = value;  }
}



public virtual string Cp {
        get { return cp; } set { cp = value;  }
}



public virtual string Provincia {
        get { return provincia; } set { provincia = value;  }
}



public virtual string Pais {
        get { return pais; } set { pais = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ServicioEN> Servicios {
        get { return servicios; } set { servicios = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.EmpleadoEN> Empleado {
        get { return empleado; } set { empleado = value;  }
}



public virtual RestGenNHibernate.EN.Rest.EmpresaEN Empresa {
        get { return empresa; } set { empresa = value;  }
}



public virtual RestGenNHibernate.EN.Rest.MesaEN Mesa {
        get { return mesa; } set { mesa = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.IngredienteEN> Ingrediente {
        get { return ingrediente; } set { ingrediente = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.CajaEN> Caja {
        get { return caja; } set { caja = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.MovimientoEN> Movimiento {
        get { return movimiento; } set { movimiento = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoProveedorEN> PedidoProveedor {
        get { return pedidoProveedor; } set { pedidoProveedor = value;  }
}





public NegocioEN()
{
        servicios = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.ServicioEN>();
        empleado = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.EmpleadoEN>();
        ingrediente = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.IngredienteEN>();
        caja = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.CajaEN>();
        movimiento = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.MovimientoEN>();
        pedidoProveedor = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.PedidoProveedorEN>();
}



public NegocioEN(int id, string nombre, string direccion, string ciudad, string cp, string provincia, string pais, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ServicioEN> servicios, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.EmpleadoEN> empleado, RestGenNHibernate.EN.Rest.EmpresaEN empresa, RestGenNHibernate.EN.Rest.MesaEN mesa, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.IngredienteEN> ingrediente, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.CajaEN> caja, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.MovimientoEN> movimiento, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoProveedorEN> pedidoProveedor
                 )
{
        this.init (Id, nombre, direccion, ciudad, cp, provincia, pais, servicios, empleado, empresa, mesa, ingrediente, caja, movimiento, pedidoProveedor);
}


public NegocioEN(NegocioEN negocio)
{
        this.init (Id, negocio.Nombre, negocio.Direccion, negocio.Ciudad, negocio.Cp, negocio.Provincia, negocio.Pais, negocio.Servicios, negocio.Empleado, negocio.Empresa, negocio.Mesa, negocio.Ingrediente, negocio.Caja, negocio.Movimiento, negocio.PedidoProveedor);
}

private void init (int id
                   , string nombre, string direccion, string ciudad, string cp, string provincia, string pais, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ServicioEN> servicios, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.EmpleadoEN> empleado, RestGenNHibernate.EN.Rest.EmpresaEN empresa, RestGenNHibernate.EN.Rest.MesaEN mesa, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.IngredienteEN> ingrediente, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.CajaEN> caja, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.MovimientoEN> movimiento, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoProveedorEN> pedidoProveedor)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Direccion = direccion;

        this.Ciudad = ciudad;

        this.Cp = cp;

        this.Provincia = provincia;

        this.Pais = pais;

        this.Servicios = servicios;

        this.Empleado = empleado;

        this.Empresa = empresa;

        this.Mesa = mesa;

        this.Ingrediente = ingrediente;

        this.Caja = caja;

        this.Movimiento = movimiento;

        this.PedidoProveedor = pedidoProveedor;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        NegocioEN t = obj as NegocioEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
