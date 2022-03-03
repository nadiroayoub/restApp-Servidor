
using System;
// Definición clase MenuEN
namespace RestGenNHibernate.EN.Rest
{
public partial class MenuEN
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
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> lineaPedido;



/**
 *	Atributo plato
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoEN> plato;



/**
 *	Atributo stock
 */
private int stock;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoEN> Plato {
        get { return plato; } set { plato = value;  }
}



public virtual int Stock {
        get { return stock; } set { stock = value;  }
}





public MenuEN()
{
        lineaPedido = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.LineaPedidoEN>();
        plato = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.PlatoEN>();
}



public MenuEN(int id, string nombre, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoEN> plato, int stock
              )
{
        this.init (Id, nombre, lineaPedido, plato, stock);
}


public MenuEN(MenuEN menu)
{
        this.init (Id, menu.Nombre, menu.LineaPedido, menu.Plato, menu.Stock);
}

private void init (int id
                   , string nombre, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoEN> plato, int stock)
{
        this.Id = id;


        this.Nombre = nombre;

        this.LineaPedido = lineaPedido;

        this.Plato = plato;

        this.Stock = stock;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MenuEN t = obj as MenuEN;
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
