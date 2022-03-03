
using System;
// Definición clase TransacCreditCardEN
namespace RestGenNHibernate.EN.Rest
{
public partial class TransacCreditCardEN                                                                    : RestGenNHibernate.EN.Rest.PagoEN


{
/**
 *	Atributo nombreOwenCard
 */
private string nombreOwenCard;






public virtual string NombreOwenCard {
        get { return nombreOwenCard; } set { nombreOwenCard = value;  }
}





public TransacCreditCardEN() : base ()
{
}



public TransacCreditCardEN(int id, string nombreOwenCard
                           , double monto, RestGenNHibernate.EN.Rest.PedidoEN pedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> cliente
                           )
{
        this.init (Id, nombreOwenCard, monto, pedido, cliente);
}


public TransacCreditCardEN(TransacCreditCardEN transacCreditCard)
{
        this.init (Id, transacCreditCard.NombreOwenCard, transacCreditCard.Monto, transacCreditCard.Pedido, transacCreditCard.Cliente);
}

private void init (int id
                   , string nombreOwenCard, double monto, RestGenNHibernate.EN.Rest.PedidoEN pedido, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.ClienteEN> cliente)
{
        this.Id = id;


        this.NombreOwenCard = nombreOwenCard;

        this.Monto = monto;

        this.Pedido = pedido;

        this.Cliente = cliente;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TransacCreditCardEN t = obj as TransacCreditCardEN;
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
