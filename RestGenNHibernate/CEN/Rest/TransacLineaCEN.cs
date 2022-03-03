

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
 *      Definition of the class TransacLineaCEN
 *
 */
public partial class TransacLineaCEN
{
private ITransacLineaCAD _ITransacLineaCAD;

public TransacLineaCEN()
{
        this._ITransacLineaCAD = new TransacLineaCAD ();
}

public TransacLineaCEN(ITransacLineaCAD _ITransacLineaCAD)
{
        this._ITransacLineaCAD = _ITransacLineaCAD;
}

public ITransacLineaCAD get_ITransacLineaCAD ()
{
        return this._ITransacLineaCAD;
}

public int Nuevo (double p_monto, int p_pedido, string p_nombre, string p_numero)
{
        TransacLineaEN transacLineaEN = null;
        int oid;

        //Initialized TransacLineaEN
        transacLineaEN = new TransacLineaEN ();
        transacLineaEN.Monto = p_monto;


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                transacLineaEN.Pedido = new RestGenNHibernate.EN.Rest.PedidoEN ();
                transacLineaEN.Pedido.Id = p_pedido;
        }

        transacLineaEN.Nombre = p_nombre;

        transacLineaEN.Numero = p_numero;

        //Call to TransacLineaCAD

        oid = _ITransacLineaCAD.Nuevo (transacLineaEN);
        return oid;
}

public void Modificar (int p_TransacLinea_OID, double p_monto, string p_nombre, string p_numero)
{
        TransacLineaEN transacLineaEN = null;

        //Initialized TransacLineaEN
        transacLineaEN = new TransacLineaEN ();
        transacLineaEN.Id = p_TransacLinea_OID;
        transacLineaEN.Monto = p_monto;
        transacLineaEN.Nombre = p_nombre;
        transacLineaEN.Numero = p_numero;
        //Call to TransacLineaCAD

        _ITransacLineaCAD.Modificar (transacLineaEN);
}

public void Eliminar (int id
                      )
{
        _ITransacLineaCAD.Eliminar (id);
}
}
}
