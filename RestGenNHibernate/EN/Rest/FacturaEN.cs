
using System;
// Definición clase FacturaEN
namespace RestGenNHibernate.EN.Rest
{
    public partial class FacturaEN
    {
        /**
         *	Atributo id
         */
        private int id;



        /**
         *	Atributo numero
         */
        private string numero;



        /**
         *	Atributo fecha
         */
        private Nullable<DateTime> fecha;



/**sdasd
 *	Atributo precio
 */
private double precio;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo pedido
 */
private RestGenNHibernate.EN.Rest.PedidoEN pedido;



/**
 *	Atributo cliente
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> cliente;



/**
 *	Atributo nif_nie
 */
private string nif_nie;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Numero {
        get { return numero; } set { numero = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual double Precio {
        get { return precio; } set { precio = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual RestGenNHibernate.EN.Rest.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> Cliente {
        get { return cliente; } set { cliente = value;  }
}



public virtual string Nif_nie {
        get { return nif_nie; } set { nif_nie = value;  }
}





public FacturaEN()
{
        cliente = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.ClienteEN>();
}



public FacturaEN(int id, string numero, Nullable<DateTime> fecha, double precio, string descripcion, RestGenNHibernate.EN.Rest.PedidoEN pedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> cliente, string nif_nie
                 )
{
        this.init (Id, numero, fecha, precio, descripcion, pedido, cliente, nif_nie);
}


public FacturaEN(FacturaEN factura)
{
        this.init (Id, factura.Numero, factura.Fecha, factura.Precio, factura.Descripcion, factura.Pedido, factura.Cliente, factura.Nif_nie);
}

private void init (int id
                   , string numero, Nullable<DateTime> fecha, double precio, string descripcion, RestGenNHibernate.EN.Rest.PedidoEN pedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> cliente, string nif_nie)
{
        this.Id = id;


        this.Numero = numero;

        this.Fecha = fecha;

        this.Precio = precio;

        this.Descripcion = descripcion;

        this.Pedido = pedido;

        this.Cliente = cliente;

        this.Nif_nie = nif_nie;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FacturaEN t = obj as FacturaEN;
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
