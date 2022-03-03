

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
 *      Definition of the class PagoCEN
 *
 */
public partial class PagoCEN
{
private IPagoCAD _IPagoCAD;

public PagoCEN()
{
        this._IPagoCAD = new PagoCAD ();
}

public PagoCEN(IPagoCAD _IPagoCAD)
{
        this._IPagoCAD = _IPagoCAD;
}

public IPagoCAD get_IPagoCAD ()
{
        return this._IPagoCAD;
}

public int Nuevo (double p_monto, int p_pedido)
{
        PagoEN pagoEN = null;
        int oid;

        //Initialized PagoEN
        pagoEN = new PagoEN ();
        pagoEN.Monto = p_monto;


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                pagoEN.Pedido = new RestGenNHibernate.EN.Rest.PedidoEN ();
                pagoEN.Pedido.Id = p_pedido;
        }

        //Call to PagoCAD

        oid = _IPagoCAD.Nuevo (pagoEN);
        return oid;
}

public void Modificar (int p_Pago_OID, double p_monto)
{
        PagoEN pagoEN = null;

        //Initialized PagoEN
        pagoEN = new PagoEN ();
        pagoEN.Id = p_Pago_OID;
        pagoEN.Monto = p_monto;
        //Call to PagoCAD

        _IPagoCAD.Modificar (pagoEN);
}

public void Eliminar (int id
                      )
{
        _IPagoCAD.Eliminar (id);
}

public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PagoEN> DamePagos ()
{
        return _IPagoCAD.DamePagos ();
}
}
}
