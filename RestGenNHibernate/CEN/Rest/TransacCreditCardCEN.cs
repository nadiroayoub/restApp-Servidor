

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using RestGenNHibernate.Exceptions;

using RestGenNHibernate.EN.Rest;
using RestGenNHibernate.CAD.Rest;


namespace RestGenNHibernate.CEN.Rest
{
/*
 *      Definition of the class TransacCreditCardCEN
 *
 */
public partial class TransacCreditCardCEN
{
private ITransacCreditCardCAD _ITransacCreditCardCAD;

public TransacCreditCardCEN()
{
        this._ITransacCreditCardCAD = new TransacCreditCardCAD ();
}

public TransacCreditCardCEN(ITransacCreditCardCAD _ITransacCreditCardCAD)
{
        this._ITransacCreditCardCAD = _ITransacCreditCardCAD;
}

public ITransacCreditCardCAD get_ITransacCreditCardCAD ()
{
        return this._ITransacCreditCardCAD;
}

public int Nuevo (double p_monto, int p_pedido, string p_nombreOwenCard)
{
        TransacCreditCardEN transacCreditCardEN = null;
        int oid;

        //Initialized TransacCreditCardEN
        transacCreditCardEN = new TransacCreditCardEN ();
        transacCreditCardEN.Monto = p_monto;


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                transacCreditCardEN.Pedido = new RestGenNHibernate.EN.Rest.PedidoEN ();
                transacCreditCardEN.Pedido.Id = p_pedido;
        }

        transacCreditCardEN.NombreOwenCard = p_nombreOwenCard;

        //Call to TransacCreditCardCAD

        oid = _ITransacCreditCardCAD.Nuevo (transacCreditCardEN);
        return oid;
}

public void Modificar (int p_TransacCreditCard_OID, double p_monto, string p_nombreOwenCard)
{
        TransacCreditCardEN transacCreditCardEN = null;

        //Initialized TransacCreditCardEN
        transacCreditCardEN = new TransacCreditCardEN ();
        transacCreditCardEN.Id = p_TransacCreditCard_OID;
        transacCreditCardEN.Monto = p_monto;
        transacCreditCardEN.NombreOwenCard = p_nombreOwenCard;
        //Call to TransacCreditCardCAD

        _ITransacCreditCardCAD.Modificar (transacCreditCardEN);
}

public void Eliminar (int id
                      )
{
        _ITransacCreditCardCAD.Eliminar (id);
}
}
}
