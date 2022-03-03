
using System;
// Definición clase ClienteEN
namespace RestGenNHibernate.EN.Rest
{
public partial class ClienteEN
{
/**
 *	Atributo dni
 */
private string dni;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo mesa
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.MesaEN> mesa;



/**
 *	Atributo factura
 */
private RestGenNHibernate.EN.Rest.FacturaEN factura;



/**
 *	Atributo pago
 */
private RestGenNHibernate.EN.Rest.PagoEN pago;






public virtual string Dni {
        get { return dni; } set { dni = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.MesaEN> Mesa {
        get { return mesa; } set { mesa = value;  }
}



public virtual RestGenNHibernate.EN.Rest.FacturaEN Factura {
        get { return factura; } set { factura = value;  }
}



public virtual RestGenNHibernate.EN.Rest.PagoEN Pago {
        get { return pago; } set { pago = value;  }
}





public ClienteEN()
{
        mesa = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.MesaEN>();
}



public ClienteEN(string dni, string nombre, string apellidos, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.MesaEN> mesa, RestGenNHibernate.EN.Rest.FacturaEN factura, RestGenNHibernate.EN.Rest.PagoEN pago
                 )
{
        this.init (Dni, nombre, apellidos, mesa, factura, pago);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (Dni, cliente.Nombre, cliente.Apellidos, cliente.Mesa, cliente.Factura, cliente.Pago);
}

private void init (string dni
                   , string nombre, string apellidos, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.MesaEN> mesa, RestGenNHibernate.EN.Rest.FacturaEN factura, RestGenNHibernate.EN.Rest.PagoEN pago)
{
        this.Dni = dni;


        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Mesa = mesa;

        this.Factura = factura;

        this.Pago = pago;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ClienteEN t = obj as ClienteEN;
        if (t == null)
                return false;
        if (Dni.Equals (t.Dni))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Dni.GetHashCode ();
        return hash;
}
}
}
