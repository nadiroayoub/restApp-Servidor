
using System;
// Definición clase CajaEN
namespace RestGenNHibernate.EN.Rest
{
public partial class CajaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo fondo
 */
private double fondo;



/**
 *	Atributo cash
 */
private double cash;



/**
 *	Atributo desfase
 */
private double desfase;



/**
 *	Atributo negocio
 */
private RestGenNHibernate.EN.Rest.NegocioEN negocio;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> pedido;



/**
 *	Atributo encargado
 */
private RestGenNHibernate.EN.Rest.EncargadoEN encargado;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual double Fondo {
        get { return fondo; } set { fondo = value;  }
}



public virtual double Cash {
        get { return cash; } set { cash = value;  }
}



public virtual double Desfase {
        get { return desfase; } set { desfase = value;  }
}



public virtual RestGenNHibernate.EN.Rest.NegocioEN Negocio {
        get { return negocio; } set { negocio = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual RestGenNHibernate.EN.Rest.EncargadoEN Encargado {
        get { return encargado; } set { encargado = value;  }
}





public CajaEN()
{
        pedido = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.PedidoEN>();
}



public CajaEN(int id, Nullable<DateTime> fecha, double fondo, double cash, double desfase, RestGenNHibernate.EN.Rest.NegocioEN negocio, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> pedido, RestGenNHibernate.EN.Rest.EncargadoEN encargado
              )
{
        this.init (Id, fecha, fondo, cash, desfase, negocio, pedido, encargado);
}


public CajaEN(CajaEN caja)
{
        this.init (Id, caja.Fecha, caja.Fondo, caja.Cash, caja.Desfase, caja.Negocio, caja.Pedido, caja.Encargado);
}

private void init (int id
                   , Nullable<DateTime> fecha, double fondo, double cash, double desfase, RestGenNHibernate.EN.Rest.NegocioEN negocio, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> pedido, RestGenNHibernate.EN.Rest.EncargadoEN encargado)
{
        this.Id = id;


        this.Fecha = fecha;

        this.Fondo = fondo;

        this.Cash = cash;

        this.Desfase = desfase;

        this.Negocio = negocio;

        this.Pedido = pedido;

        this.Encargado = encargado;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CajaEN t = obj as CajaEN;
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
