
using System;
// Definición clase TransacLineaEN
namespace RestGenNHibernate.EN.Rest
{
public partial class TransacLineaEN                                                                 : RestGenNHibernate.EN.Rest.PagoEN


{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo numero
 */
private string numero;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Numero {
        get { return numero; } set { numero = value;  }
}





public TransacLineaEN() : base ()
{
}



public TransacLineaEN(int id, string nombre, string numero
                      , double monto, RestGenNHibernate.EN.Rest.PedidoEN pedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> cliente
                      )
{
        this.init (Id, nombre, numero, monto, pedido, cliente);
}


public TransacLineaEN(TransacLineaEN transacLinea)
{
        this.init (Id, transacLinea.Nombre, transacLinea.Numero, transacLinea.Monto, transacLinea.Pedido, transacLinea.Cliente);
}

private void init (int id
                   , string nombre, string numero, double monto, RestGenNHibernate.EN.Rest.PedidoEN pedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> cliente)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Numero = numero;

        this.Monto = monto;

        this.Pedido = pedido;

        this.Cliente = cliente;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TransacLineaEN t = obj as TransacLineaEN;
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
