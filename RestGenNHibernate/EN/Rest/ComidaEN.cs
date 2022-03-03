
using System;
// Definición clase ComidaEN
namespace RestGenNHibernate.EN.Rest
{
public partial class ComidaEN                                                                       : RestGenNHibernate.EN.Rest.PlatoEN


{
/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo informacionCalorica
 */
private string informacionCalorica;






public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string InformacionCalorica {
        get { return informacionCalorica; } set { informacionCalorica = value;  }
}





public ComidaEN() : base ()
{
}



public ComidaEN(int id, string descripcion, string informacionCalorica
                , System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> lineaPedido, RestGenNHibernate.EN.Rest.MenuEN menu, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoIngredienteEN> platoIngrediente, string nombre, int stock
                )
{
        this.init (Id, descripcion, informacionCalorica, lineaPedido, menu, platoIngrediente, nombre, stock);
}


public ComidaEN(ComidaEN comida)
{
        this.init (Id, comida.Descripcion, comida.InformacionCalorica, comida.LineaPedido, comida.Menu, comida.PlatoIngrediente, comida.Nombre, comida.Stock);
}

private void init (int id
                   , string descripcion, string informacionCalorica, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> lineaPedido, RestGenNHibernate.EN.Rest.MenuEN menu, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoIngredienteEN> platoIngrediente, string nombre, int stock)
{
        this.Id = id;


        this.Descripcion = descripcion;

        this.InformacionCalorica = informacionCalorica;

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
        ComidaEN t = obj as ComidaEN;
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
