
using System;
// Definición clase PedidoProveedorEN
namespace RestGenNHibernate.EN.Rest
{
public partial class PedidoProveedorEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo lineaProveedor
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN> lineaProveedor;



/**
 *	Atributo proveedor
 */
private RestGenNHibernate.EN.Rest.ProveedorEN proveedor;



/**
 *	Atributo negocio
 */
private RestGenNHibernate.EN.Rest.NegocioEN negocio;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN> LineaProveedor {
        get { return lineaProveedor; } set { lineaProveedor = value;  }
}



public virtual RestGenNHibernate.EN.Rest.ProveedorEN Proveedor {
        get { return proveedor; } set { proveedor = value;  }
}



public virtual RestGenNHibernate.EN.Rest.NegocioEN Negocio {
        get { return negocio; } set { negocio = value;  }
}





public PedidoProveedorEN()
{
        lineaProveedor = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN>();
}



public PedidoProveedorEN(int id, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN> lineaProveedor, RestGenNHibernate.EN.Rest.ProveedorEN proveedor, RestGenNHibernate.EN.Rest.NegocioEN negocio
                         )
{
        this.init (Id, lineaProveedor, proveedor, negocio);
}


public PedidoProveedorEN(PedidoProveedorEN pedidoProveedor)
{
        this.init (Id, pedidoProveedor.LineaProveedor, pedidoProveedor.Proveedor, pedidoProveedor.Negocio);
}

private void init (int id
                   , System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN> lineaProveedor, RestGenNHibernate.EN.Rest.ProveedorEN proveedor, RestGenNHibernate.EN.Rest.NegocioEN negocio)
{
        this.Id = id;


        this.LineaProveedor = lineaProveedor;

        this.Proveedor = proveedor;

        this.Negocio = negocio;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoProveedorEN t = obj as PedidoProveedorEN;
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
