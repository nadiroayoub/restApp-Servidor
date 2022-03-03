
using System;
// Definición clase PagoEN
namespace RestGenNHibernate.EN.Rest
{
public partial class PagoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo monto
 */
private double monto;



/**
 *	Atributo pedido
 */
private RestGenNHibernate.EN.Rest.PedidoEN pedido;



/**
 *	Atributo cliente
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> cliente;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual double Monto {
        get { return monto; } set { monto = value;  }
}



public virtual RestGenNHibernate.EN.Rest.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> Cliente {
        get { return cliente; } set { cliente = value;  }
}





public PagoEN()
{
        cliente = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.ClienteEN>();
}



public PagoEN(int id, double monto, RestGenNHibernate.EN.Rest.PedidoEN pedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> cliente
              )
{
        this.init (Id, monto, pedido, cliente);
}


public PagoEN(PagoEN pago)
{
        this.init (Id, pago.Monto, pago.Pedido, pago.Cliente);
}

private void init (int id
                   , double monto, RestGenNHibernate.EN.Rest.PedidoEN pedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> cliente)
{
        this.Id = id;


        this.Monto = monto;

        this.Pedido = pedido;

        this.Cliente = cliente;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PagoEN t = obj as PagoEN;
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
