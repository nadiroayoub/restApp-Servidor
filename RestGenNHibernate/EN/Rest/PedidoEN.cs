
using System;
// Definición clase PedidoEN
namespace RestGenNHibernate.EN.Rest
{
public partial class PedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo estadoPedido
 */
private RestGenNHibernate.Enumerated.Rest.EstadoPedidoEnum estadoPedido;



/**
 *	Atributo camarero
 */
private RestGenNHibernate.EN.Rest.CamareroEN camarero;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> lineaPedido;



/**
 *	Atributo pago
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PagoEN> pago;



/**
 *	Atributo mesa
 */
private RestGenNHibernate.EN.Rest.MesaEN mesa;



/**
 *	Atributo factura
 */
private RestGenNHibernate.EN.Rest.FacturaEN factura;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo caja
 */
private RestGenNHibernate.EN.Rest.CajaEN caja;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual RestGenNHibernate.Enumerated.Rest.EstadoPedidoEnum EstadoPedido {
        get { return estadoPedido; } set { estadoPedido = value;  }
}



public virtual RestGenNHibernate.EN.Rest.CamareroEN Camarero {
        get { return camarero; } set { camarero = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PagoEN> Pago {
        get { return pago; } set { pago = value;  }
}



public virtual RestGenNHibernate.EN.Rest.MesaEN Mesa {
        get { return mesa; } set { mesa = value;  }
}



public virtual RestGenNHibernate.EN.Rest.FacturaEN Factura {
        get { return factura; } set { factura = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual RestGenNHibernate.EN.Rest.CajaEN Caja {
        get { return caja; } set { caja = value;  }
}





public PedidoEN()
{
        lineaPedido = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.LineaPedidoEN>();
        pago = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.PagoEN>();
}



public PedidoEN(int id, RestGenNHibernate.Enumerated.Rest.EstadoPedidoEnum estadoPedido, RestGenNHibernate.EN.Rest.CamareroEN camarero, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PagoEN> pago, RestGenNHibernate.EN.Rest.MesaEN mesa, RestGenNHibernate.EN.Rest.FacturaEN factura, Nullable<DateTime> fecha, RestGenNHibernate.EN.Rest.CajaEN caja
                )
{
        this.init (Id, estadoPedido, camarero, lineaPedido, pago, mesa, factura, fecha, caja);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (Id, pedido.EstadoPedido, pedido.Camarero, pedido.LineaPedido, pedido.Pago, pedido.Mesa, pedido.Factura, pedido.Fecha, pedido.Caja);
}

private void init (int id
                   , RestGenNHibernate.Enumerated.Rest.EstadoPedidoEnum estadoPedido, RestGenNHibernate.EN.Rest.CamareroEN camarero, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PagoEN> pago, RestGenNHibernate.EN.Rest.MesaEN mesa, RestGenNHibernate.EN.Rest.FacturaEN factura, Nullable<DateTime> fecha, RestGenNHibernate.EN.Rest.CajaEN caja)
{
        this.Id = id;


        this.EstadoPedido = estadoPedido;

        this.Camarero = camarero;

        this.LineaPedido = lineaPedido;

        this.Pago = pago;

        this.Mesa = mesa;

        this.Factura = factura;

        this.Fecha = fecha;

        this.Caja = caja;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoEN t = obj as PedidoEN;
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
