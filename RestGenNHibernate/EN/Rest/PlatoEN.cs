
using System;
// Definición clase PlatoEN
namespace RestGenNHibernate.EN.Rest
{
public partial class PlatoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> lineaPedido;



/**
 *	Atributo menu
 */
private RestGenNHibernate.EN.Rest.MenuEN menu;



/**
 *	Atributo platoIngrediente
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoIngredienteEN> platoIngrediente;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo stock
 */
private int stock;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual RestGenNHibernate.EN.Rest.MenuEN Menu {
        get { return menu; } set { menu = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoIngredienteEN> PlatoIngrediente {
        get { return platoIngrediente; } set { platoIngrediente = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual int Stock {
        get { return stock; } set { stock = value;  }
}





public PlatoEN()
{
        lineaPedido = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.LineaPedidoEN>();
        platoIngrediente = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.PlatoIngredienteEN>();
}



public PlatoEN(int id, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> lineaPedido, RestGenNHibernate.EN.Rest.MenuEN menu, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoIngredienteEN> platoIngrediente, string nombre, int stock
               )
{
        this.init (Id, lineaPedido, menu, platoIngrediente, nombre, stock);
}


public PlatoEN(PlatoEN plato)
{
        this.init (Id, plato.LineaPedido, plato.Menu, plato.PlatoIngrediente, plato.Nombre, plato.Stock);
}

private void init (int id
                   , System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> lineaPedido, RestGenNHibernate.EN.Rest.MenuEN menu, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoIngredienteEN> platoIngrediente, string nombre, int stock)
{
        this.Id = id;


        this.LineaPedido = lineaPedido;

        this.Menu = menu;

        this.PlatoIngrediente = platoIngrediente;

        this.Nombre = nombre;

        this.Stock = stock;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PlatoEN t = obj as PlatoEN;
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
