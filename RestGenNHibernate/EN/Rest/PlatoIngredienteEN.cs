
using System;
// Definición clase PlatoIngredienteEN
namespace RestGenNHibernate.EN.Rest
{
public partial class PlatoIngredienteEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo cantidad
 */
private double cantidad;



/**
 *	Atributo plato
 */
private RestGenNHibernate.EN.Rest.PlatoEN plato;



/**
 *	Atributo ingrediente
 */
private RestGenNHibernate.EN.Rest.IngredienteEN ingrediente;



/**
 *	Atributo stock
 */
private double stock;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual double Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual RestGenNHibernate.EN.Rest.PlatoEN Plato {
        get { return plato; } set { plato = value;  }
}



public virtual RestGenNHibernate.EN.Rest.IngredienteEN Ingrediente {
        get { return ingrediente; } set { ingrediente = value;  }
}



public virtual double Stock {
        get { return stock; } set { stock = value;  }
}





public PlatoIngredienteEN()
{
}



public PlatoIngredienteEN(int id, double cantidad, RestGenNHibernate.EN.Rest.PlatoEN plato, RestGenNHibernate.EN.Rest.IngredienteEN ingrediente, double stock
                          )
{
        this.init (Id, cantidad, plato, ingrediente, stock);
}


public PlatoIngredienteEN(PlatoIngredienteEN platoIngrediente)
{
        this.init (Id, platoIngrediente.Cantidad, platoIngrediente.Plato, platoIngrediente.Ingrediente, platoIngrediente.Stock);
}

private void init (int id
                   , double cantidad, RestGenNHibernate.EN.Rest.PlatoEN plato, RestGenNHibernate.EN.Rest.IngredienteEN ingrediente, double stock)
{
        this.Id = id;


        this.Cantidad = cantidad;

        this.Plato = plato;

        this.Ingrediente = ingrediente;

        this.Stock = stock;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PlatoIngredienteEN t = obj as PlatoIngredienteEN;
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
