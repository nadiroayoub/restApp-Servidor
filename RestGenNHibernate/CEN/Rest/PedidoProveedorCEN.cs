

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
 *      Definition of the class PedidoProveedorCEN
 *
 */
public partial class PedidoProveedorCEN
{
private IPedidoProveedorCAD _IPedidoProveedorCAD;

public PedidoProveedorCEN()
{
        this._IPedidoProveedorCAD = new PedidoProveedorCAD ();
}

public PedidoProveedorCEN(IPedidoProveedorCAD _IPedidoProveedorCAD)
{
        this._IPedidoProveedorCAD = _IPedidoProveedorCAD;
}

public IPedidoProveedorCAD get_IPedidoProveedorCAD ()
{
        return this._IPedidoProveedorCAD;
}

public int Nuevo (int p_proveedor, int p_negocio)
{
        PedidoProveedorEN pedidoProveedorEN = null;
        int oid;

        //Initialized PedidoProveedorEN
        pedidoProveedorEN = new PedidoProveedorEN ();

        if (p_proveedor != -1) {
                // El argumento p_proveedor -> Property proveedor es oid = false
                // Lista de oids id
                pedidoProveedorEN.Proveedor = new RestGenNHibernate.EN.Rest.ProveedorEN ();
                pedidoProveedorEN.Proveedor.Id = p_proveedor;
        }


        if (p_negocio != -1) {
                // El argumento p_negocio -> Property negocio es oid = false
                // Lista de oids id
                pedidoProveedorEN.Negocio = new RestGenNHibernate.EN.Rest.NegocioEN ();
                pedidoProveedorEN.Negocio.Id = p_negocio;
        }

        //Call to PedidoProveedorCAD

        oid = _IPedidoProveedorCAD.Nuevo (pedidoProveedorEN);
        return oid;
}

public void Modificar (int p_PedidoProveedor_OID)
{
        PedidoProveedorEN pedidoProveedorEN = null;

        //Initialized PedidoProveedorEN
        pedidoProveedorEN = new PedidoProveedorEN ();
        pedidoProveedorEN.Id = p_PedidoProveedor_OID;
        //Call to PedidoProveedorCAD

        _IPedidoProveedorCAD.Modificar (pedidoProveedorEN);
}

public void Eliminar (int id
                      )
{
        _IPedidoProveedorCAD.Eliminar (id);
}
}
}
