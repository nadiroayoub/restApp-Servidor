
using System;
// Definición clase ServicioEN
namespace RestGenNHibernate.EN.Rest
{
public partial class ServicioEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo tipo
 */
private RestGenNHibernate.Enumerated.Rest.TipoServicioEnum tipo;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo negocio
 */
private RestGenNHibernate.EN.Rest.NegocioEN negocio;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo monto
 */
private double monto;



/**
 *	Atributo lineaProveedor
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN> lineaProveedor;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual RestGenNHibernate.Enumerated.Rest.TipoServicioEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual RestGenNHibernate.EN.Rest.NegocioEN Negocio {
        get { return negocio; } set { negocio = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual double Monto {
        get { return monto; } set { monto = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN> LineaProveedor {
        get { return lineaProveedor; } set { lineaProveedor = value;  }
}





public ServicioEN()
{
        lineaProveedor = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN>();
}



public ServicioEN(int id, RestGenNHibernate.Enumerated.Rest.TipoServicioEnum tipo, Nullable<DateTime> fecha, RestGenNHibernate.EN.Rest.NegocioEN negocio, string nombre, double monto, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN> lineaProveedor
                  )
{
        this.init (Id, tipo, fecha, negocio, nombre, monto, lineaProveedor);
}


public ServicioEN(ServicioEN servicio)
{
        this.init (Id, servicio.Tipo, servicio.Fecha, servicio.Negocio, servicio.Nombre, servicio.Monto, servicio.LineaProveedor);
}

private void init (int id
                   , RestGenNHibernate.Enumerated.Rest.TipoServicioEnum tipo, Nullable<DateTime> fecha, RestGenNHibernate.EN.Rest.NegocioEN negocio, string nombre, double monto, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoProveedorEN> lineaProveedor)
{
        this.Id = id;


        this.Tipo = tipo;

        this.Fecha = fecha;

        this.Negocio = negocio;

        this.Nombre = nombre;

        this.Monto = monto;

        this.LineaProveedor = lineaProveedor;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ServicioEN t = obj as ServicioEN;
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
