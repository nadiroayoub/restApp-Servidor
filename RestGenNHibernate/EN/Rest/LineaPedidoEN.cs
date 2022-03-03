
using System;
// Definición clase LineaPedidoEN
namespace RestGenNHibernate.EN.Rest
{
public partial class LineaPedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo pedido
 */
private RestGenNHibernate.EN.Rest.PedidoEN pedido;



/**
 *	Atributo menu
 */
private RestGenNHibernate.EN.Rest.MenuEN menu;



/**
 *	Atributo plato
 */
private RestGenNHibernate.EN.Rest.PlatoEN plato;



/**
 *	Atributo cantidad
 */
private int cantidad;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual RestGenNHibernate.EN.Rest.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual RestGenNHibernate.EN.Rest.MenuEN Menu {
        get { return menu; } set { menu = value;  }
}



public virtual RestGenNHibernate.EN.Rest.PlatoEN Plato {
        get { return plato; } set { plato = value;  }
}



public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}





public LineaPedidoEN()
{
}



public LineaPedidoEN(int id, RestGenNHibernate.EN.Rest.PedidoEN pedido, RestGenNHibernate.EN.Rest.MenuEN menu, RestGenNHibernate.EN.Rest.PlatoEN plato, int cantidad
                     )
{
        this.init (Id, pedido, menu, plato, cantidad);
}


public LineaPedidoEN(LineaPedidoEN lineaPedido)
{
        this.init (Id, lineaPedido.Pedido, lineaPedido.Menu, lineaPedido.Plato, lineaPedido.Cantidad);
}

private void init (int id
                   , RestGenNHibernate.EN.Rest.PedidoEN pedido, RestGenNHibernate.EN.Rest.MenuEN menu, RestGenNHibernate.EN.Rest.PlatoEN plato, int cantidad)
{
        this.Id = id;


        this.Pedido = pedido;

        this.Menu = menu;

        this.Plato = plato;

        this.Cantidad = cantidad;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoEN t = obj as LineaPedidoEN;
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
