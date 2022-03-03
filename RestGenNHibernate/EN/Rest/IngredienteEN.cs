
using System;
// Definición clase IngredienteEN
namespace RestGenNHibernate.EN.Rest
{
public partial class IngredienteEN
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
 *	Atributo cantidadStock
 */
private double cantidadStock;



/**
 *	Atributo unidadMedida
 */
private RestGenNHibernate.Enumerated.Rest.UnidadEnum unidadMedida;



/**
 *	Atributo negocio
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.NegocioEN> negocio;



/**
 *	Atributo platoIngrediente
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoIngredienteEN> platoIngrediente;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN> LineaProveedor {
        get { return lineaProveedor; } set { lineaProveedor = value;  }
}



public virtual double CantidadStock {
        get { return cantidadStock; } set { cantidadStock = value;  }
}



public virtual RestGenNHibernate.Enumerated.Rest.UnidadEnum UnidadMedida {
        get { return unidadMedida; } set { unidadMedida = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.NegocioEN> Negocio {
        get { return negocio; } set { negocio = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoIngredienteEN> PlatoIngrediente {
        get { return platoIngrediente; } set { platoIngrediente = value;  }
}





public IngredienteEN()
{
        lineaProveedor = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN>();
        negocio = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.NegocioEN>();
        platoIngrediente = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.PlatoIngredienteEN>();
}



public IngredienteEN(int id, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN> lineaProveedor, double cantidadStock, RestGenNHibernate.Enumerated.Rest.UnidadEnum unidadMedida, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.NegocioEN> negocio, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoIngredienteEN> platoIngrediente
                     )
{
        this.init (Id, lineaProveedor, cantidadStock, unidadMedida, negocio, platoIngrediente);
}


public IngredienteEN(IngredienteEN ingrediente)
{
        this.init (Id, ingrediente.LineaProveedor, ingrediente.CantidadStock, ingrediente.UnidadMedida, ingrediente.Negocio, ingrediente.PlatoIngrediente);
}

private void init (int id
                   , System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN> lineaProveedor, double cantidadStock, RestGenNHibernate.Enumerated.Rest.UnidadEnum unidadMedida, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.NegocioEN> negocio, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PlatoIngredienteEN> platoIngrediente)
{
        this.Id = id;


        this.LineaProveedor = lineaProveedor;

        this.CantidadStock = cantidadStock;

        this.UnidadMedida = unidadMedida;

        this.Negocio = negocio;

        this.PlatoIngrediente = platoIngrediente;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IngredienteEN t = obj as IngredienteEN;
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
