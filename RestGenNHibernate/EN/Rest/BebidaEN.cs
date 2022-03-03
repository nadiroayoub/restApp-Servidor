
using System;
// Definición clase BebidaEN
namespace RestGenNHibernate.EN.Rest
{
public partial class BebidaEN                                                                       : RestGenNHibernate.EN.Rest.PlatoEN


{
/**
 *	Atributo tipo
 */
private RestGenNHibernate.Enumerated.Rest.TipoBebidaEnum tipo;



/**
 *	Atributo descripcion
 */
private string descripcion;






public virtual RestGenNHibernate.Enumerated.Rest.TipoBebidaEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}





public BebidaEN() : base ()
{
}



public BebidaEN(int id, RestGenNHibernate.Enumerated.Rest.TipoBebidaEnum tipo, string descripcion
                , System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> lineaPedido, RestGenNHibernate.EN.Rest.MenuEN menu, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoIngredienteEN> platoIngrediente, string nombre, int stock
                )
{
        this.init (Id, tipo, descripcion, lineaPedido, menu, platoIngrediente, nombre, stock);
}


public BebidaEN(BebidaEN bebida)
{
        this.init (Id, bebida.Tipo, bebida.Descripcion, bebida.LineaPedido, bebida.Menu, bebida.PlatoIngrediente, bebida.Nombre, bebida.Stock);
}

private void init (int id
                   , RestGenNHibernate.Enumerated.Rest.TipoBebidaEnum tipo, string descripcion, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> lineaPedido, RestGenNHibernate.EN.Rest.MenuEN menu, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoIngredienteEN> platoIngrediente, string nombre, int stock)
{
        this.Id = id;


        this.Tipo = tipo;

        this.Descripcion = descripcion;

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
        BebidaEN t = obj as BebidaEN;
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
