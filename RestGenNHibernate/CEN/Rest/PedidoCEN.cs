

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
 *      Definition of the class PedidoCEN
 *
 */
public partial class PedidoCEN
{
private IPedidoCAD _IPedidoCAD;

public PedidoCEN()
{
        this._IPedidoCAD = new PedidoCAD ();
}

public PedidoCEN(IPedidoCAD _IPedidoCAD)
{
        this._IPedidoCAD = _IPedidoCAD;
}

public IPedidoCAD get_IPedidoCAD ()
{
        return this._IPedidoCAD;
}

public int Nuevo (RestGenNHibernate.Enumerated.Rest.EstadoPedidoEnum p_estadoPedido, int p_camarero, int p_mesa, Nullable<DateTime> p_fecha, int p_caja)
{
        PedidoEN pedidoEN = null;
        int oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.EstadoPedido = p_estadoPedido;


        if (p_camarero != -1) {
                // El argumento p_camarero -> Property camarero es oid = false
                // Lista de oids id
                pedidoEN.Camarero = new RestGenNHibernate.EN.Rest.CamareroEN ();
                pedidoEN.Camarero.Id = p_camarero;
        }


        if (p_mesa != -1) {
                // El argumento p_mesa -> Property mesa es oid = false
                // Lista de oids id
                pedidoEN.Mesa = new RestGenNHibernate.EN.Rest.MesaEN ();
                pedidoEN.Mesa.Id = p_mesa;
        }

        pedidoEN.Fecha = p_fecha;


        if (p_caja != -1) {
                // El argumento p_caja -> Property caja es oid = false
                // Lista de oids id
                pedidoEN.Caja = new RestGenNHibernate.EN.Rest.CajaEN ();
                pedidoEN.Caja.Id = p_caja;
        }

        //Call to PedidoCAD

        oid = _IPedidoCAD.Nuevo (pedidoEN);
        return oid;
}

public void Modificar (int p_Pedido_OID, RestGenNHibernate.Enumerated.Rest.EstadoPedidoEnum p_estadoPedido, Nullable<DateTime> p_fecha)
{
        PedidoEN pedidoEN = null;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Id = p_Pedido_OID;
        pedidoEN.EstadoPedido = p_estadoPedido;
        pedidoEN.Fecha = p_fecha;
        //Call to PedidoCAD

        _IPedidoCAD.Modificar (pedidoEN);
}

public void Eliminar (int id
                      )
{
        _IPedidoCAD.Eliminar (id);
}

public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> DamePedidoPlato ()
{
        return _IPedidoCAD.DamePedidoPlato ();
}
public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> DamePedidoMenu ()
{
        return _IPedidoCAD.DamePedidoMenu ();
}
}
}
