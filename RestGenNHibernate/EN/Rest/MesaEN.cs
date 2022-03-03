
using System;
// Definición clase MesaEN
namespace RestGenNHibernate.EN.Rest
{
public partial class MesaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo cantidadPersonas
 */
private int cantidadPersonas;



/**
 *	Atributo cliente
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> cliente;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> pedido;



/**
 *	Atributo negocio
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.NegocioEN> negocio;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int CantidadPersonas {
        get { return cantidadPersonas; } set { cantidadPersonas = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> Cliente {
        get { return cliente; } set { cliente = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.NegocioEN> Negocio {
        get { return negocio; } set { negocio = value;  }
}





public MesaEN()
{
        cliente = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.ClienteEN>();
        pedido = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.PedidoEN>();
        negocio = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.NegocioEN>();
}



public MesaEN(int id, int cantidadPersonas, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> cliente, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> pedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.NegocioEN> negocio
              )
{
        this.init (Id, cantidadPersonas, cliente, pedido, negocio);
}


public MesaEN(MesaEN mesa)
{
        this.init (Id, mesa.CantidadPersonas, mesa.Cliente, mesa.Pedido, mesa.Negocio);
}

private void init (int id
                   , int cantidadPersonas, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> cliente, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> pedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.NegocioEN> negocio)
{
        this.Id = id;


        this.CantidadPersonas = cantidadPersonas;

        this.Cliente = cliente;

        this.Pedido = pedido;

        this.Negocio = negocio;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MesaEN t = obj as MesaEN;
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
