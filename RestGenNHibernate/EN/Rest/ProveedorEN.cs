
using System;
// Definición clase ProveedorEN
namespace RestGenNHibernate.EN.Rest
{
public partial class ProveedorEN
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
 *	Atributo numeroTelefono
 */
private string numeroTelefono;



/**
 *	Atributo direccion
 */
private RestGenNHibernate.Enumerated.Rest.TipoProveedorEnum direccion;



/**
 *	Atributo pedidoProveedor
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoProveedorEN> pedidoProveedor;



/**
 *	Atributo tipo
 */
private RestGenNHibernate.Enumerated.Rest.TipoProveedorEnum tipo;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string NumeroTelefono {
        get { return numeroTelefono; } set { numeroTelefono = value;  }
}



public virtual RestGenNHibernate.Enumerated.Rest.TipoProveedorEnum Direccion {
        get { return direccion; } set { direccion = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoProveedorEN> PedidoProveedor {
        get { return pedidoProveedor; } set { pedidoProveedor = value;  }
}



public virtual RestGenNHibernate.Enumerated.Rest.TipoProveedorEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}





public ProveedorEN()
{
        pedidoProveedor = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.PedidoProveedorEN>();
}



public ProveedorEN(int id, string nombre, string numeroTelefono, RestGenNHibernate.Enumerated.Rest.TipoProveedorEnum direccion, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoProveedorEN> pedidoProveedor, RestGenNHibernate.Enumerated.Rest.TipoProveedorEnum tipo
                   )
{
        this.init (Id, nombre, numeroTelefono, direccion, pedidoProveedor, tipo);
}


public ProveedorEN(ProveedorEN proveedor)
{
        this.init (Id, proveedor.Nombre, proveedor.NumeroTelefono, proveedor.Direccion, proveedor.PedidoProveedor, proveedor.Tipo);
}

private void init (int id
                   , string nombre, string numeroTelefono, RestGenNHibernate.Enumerated.Rest.TipoProveedorEnum direccion, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoProveedorEN> pedidoProveedor, RestGenNHibernate.Enumerated.Rest.TipoProveedorEnum tipo)
{
        this.Id = id;


        this.Nombre = nombre;

        this.NumeroTelefono = numeroTelefono;

        this.Direccion = direccion;

        this.PedidoProveedor = pedidoProveedor;

        this.Tipo = tipo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProveedorEN t = obj as ProveedorEN;
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
