

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
 *      Definition of the class LineaPedidoProveedorCEN
 *
 */
public partial class LineaPedidoProveedorCEN
{
private ILineaPedidoProveedorCAD _ILineaPedidoProveedorCAD;

public LineaPedidoProveedorCEN()
{
        this._ILineaPedidoProveedorCAD = new LineaPedidoProveedorCAD ();
}

public LineaPedidoProveedorCEN(ILineaPedidoProveedorCAD _ILineaPedidoProveedorCAD)
{
        this._ILineaPedidoProveedorCAD = _ILineaPedidoProveedorCAD;
}

public ILineaPedidoProveedorCAD get_ILineaPedidoProveedorCAD ()
{
        return this._ILineaPedidoProveedorCAD;
}

public int NuevaLineaServicio (int p_cantidad, int p_pedidoProveedor)
{
        LineaPedidoProveedorEN lineaPedidoProveedorEN = null;
        int oid;

        //Initialized LineaPedidoProveedorEN
        lineaPedidoProveedorEN = new LineaPedidoProveedorEN ();
        lineaPedidoProveedorEN.Cantidad = p_cantidad;


        if (p_pedidoProveedor != -1) {
                // El argumento p_pedidoProveedor -> Property pedidoProveedor es oid = false
                // Lista de oids id
                lineaPedidoProveedorEN.PedidoProveedor = new RestGenNHibernate.EN.Rest.PedidoProveedorEN ();
                lineaPedidoProveedorEN.PedidoProveedor.Id = p_pedidoProveedor;
        }

        //Call to LineaPedidoProveedorCAD

        oid = _ILineaPedidoProveedorCAD.NuevaLineaServicio (lineaPedidoProveedorEN);
        return oid;
}

public void Modificar (int p_LineaPedidoProveedor_OID, int p_cantidad)
{
        LineaPedidoProveedorEN lineaPedidoProveedorEN = null;

        //Initialized LineaPedidoProveedorEN
        lineaPedidoProveedorEN = new LineaPedidoProveedorEN ();
        lineaPedidoProveedorEN.Id = p_LineaPedidoProveedor_OID;
        lineaPedidoProveedorEN.Cantidad = p_cantidad;
        //Call to LineaPedidoProveedorCAD

        _ILineaPedidoProveedorCAD.Modificar (lineaPedidoProveedorEN);
}

public void Eliminar (int id
                      )
{
        _ILineaPedidoProveedorCAD.Eliminar (id);
}
}
}
