
using System;
// Definición clase MovimientoEN
namespace RestGenNHibernate.EN.Rest
{
public partial class MovimientoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo fecha
 */
private string fecha;



/**
 *	Atributo cantidad
 */
private string cantidad;



/**
 *	Atributo unidad
 */
private RestGenNHibernate.Enumerated.Rest.UnidadEnum unidad;



/**
 *	Atributo negocio
 */
private RestGenNHibernate.EN.Rest.NegocioEN negocio;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual string Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual string Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual RestGenNHibernate.Enumerated.Rest.UnidadEnum Unidad {
        get { return unidad; } set { unidad = value;  }
}



public virtual RestGenNHibernate.EN.Rest.NegocioEN Negocio {
        get { return negocio; } set { negocio = value;  }
}





public MovimientoEN()
{
}



public MovimientoEN(int id, string descripcion, string fecha, string cantidad, RestGenNHibernate.Enumerated.Rest.UnidadEnum unidad, RestGenNHibernate.EN.Rest.NegocioEN negocio
                    )
{
        this.init (Id, descripcion, fecha, cantidad, unidad, negocio);
}


public MovimientoEN(MovimientoEN movimiento)
{
        this.init (Id, movimiento.Descripcion, movimiento.Fecha, movimiento.Cantidad, movimiento.Unidad, movimiento.Negocio);
}

private void init (int id
                   , string descripcion, string fecha, string cantidad, RestGenNHibernate.Enumerated.Rest.UnidadEnum unidad, RestGenNHibernate.EN.Rest.NegocioEN negocio)
{
        this.Id = id;


        this.Descripcion = descripcion;

        this.Fecha = fecha;

        this.Cantidad = cantidad;

        this.Unidad = unidad;

        this.Negocio = negocio;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MovimientoEN t = obj as MovimientoEN;
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
