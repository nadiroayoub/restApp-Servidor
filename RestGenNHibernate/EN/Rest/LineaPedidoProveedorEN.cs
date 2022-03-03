
using System;
// Definición clase LineaPedidoProveedorEN
namespace RestGenNHibernate.EN.Rest
{
public partial class LineaPedidoProveedorEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo cantidad
 */
private int cantidad;



/**
 *	Atributo servicio
 */
private RestGenNHibernate.EN.Rest.ServicioEN servicio;



/**
 *	Atributo ingrediente
 */
private RestGenNHibernate.EN.Rest.IngredienteEN ingrediente;



/**
 *	Atributo pedidoProveedor
 */
private RestGenNHibernate.EN.Rest.PedidoProveedorEN pedidoProveedor;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual RestGenNHibernate.EN.Rest.ServicioEN Servicio {
        get { return servicio; } set { servicio = value;  }
}



public virtual RestGenNHibernate.EN.Rest.IngredienteEN Ingrediente {
        get { return ingrediente; } set { ingrediente = value;  }
}



public virtual RestGenNHibernate.EN.Rest.PedidoProveedorEN PedidoProveedor {
        get { return pedidoProveedor; } set { pedidoProveedor = value;  }
}





public LineaPedidoProveedorEN()
{
}



public LineaPedidoProveedorEN(int id, int cantidad, RestGenNHibernate.EN.Rest.ServicioEN servicio, RestGenNHibernate.EN.Rest.IngredienteEN ingrediente, RestGenNHibernate.EN.Rest.PedidoProveedorEN pedidoProveedor
                              )
{
        this.init (Id, cantidad, servicio, ingrediente, pedidoProveedor);
}


public LineaPedidoProveedorEN(LineaPedidoProveedorEN lineaPedidoProveedor)
{
        this.init (Id, lineaPedidoProveedor.Cantidad, lineaPedidoProveedor.Servicio, lineaPedidoProveedor.Ingrediente, lineaPedidoProveedor.PedidoProveedor);
}

private void init (int id
                   , int cantidad, RestGenNHibernate.EN.Rest.ServicioEN servicio, RestGenNHibernate.EN.Rest.IngredienteEN ingrediente, RestGenNHibernate.EN.Rest.PedidoProveedorEN pedidoProveedor)
{
        this.Id = id;


        this.Cantidad = cantidad;

        this.Servicio = servicio;

        this.Ingrediente = ingrediente;

        this.PedidoProveedor = pedidoProveedor;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoProveedorEN t = obj as LineaPedidoProveedorEN;
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
