

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
 *      Definition of the class FacturaCEN
 *
 */
public partial class FacturaCEN
{
private IFacturaCAD _IFacturaCAD;

public FacturaCEN()
{
        this._IFacturaCAD = new FacturaCAD ();
}

public FacturaCEN(IFacturaCAD _IFacturaCAD)
{
        this._IFacturaCAD = _IFacturaCAD;
}

public IFacturaCAD get_IFacturaCAD ()
{
        return this._IFacturaCAD;
}

public int Nuevo (string p_numero, Nullable<DateTime> p_fecha, double p_precio, string p_descripcion, int p_pedido, string p_nif_nie)
{
        FacturaEN facturaEN = null;
        int oid;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Numero = p_numero;

        facturaEN.Fecha = p_fecha;

        facturaEN.Precio = p_precio;

        facturaEN.Descripcion = p_descripcion;


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                facturaEN.Pedido = new RestGenNHibernate.EN.Rest.PedidoEN ();
                facturaEN.Pedido.Id = p_pedido;
        }

        facturaEN.Nif_nie = p_nif_nie;

        //Call to FacturaCAD

        oid = _IFacturaCAD.Nuevo (facturaEN);
        return oid;
}

public void Modificar (int p_Factura_OID, string p_numero, Nullable<DateTime> p_fecha, double p_precio, string p_descripcion, string p_nif_nie)
{
        FacturaEN facturaEN = null;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Id = p_Factura_OID;
        facturaEN.Numero = p_numero;
        facturaEN.Fecha = p_fecha;
        facturaEN.Precio = p_precio;
        facturaEN.Descripcion = p_descripcion;
        facturaEN.Nif_nie = p_nif_nie;
        //Call to FacturaCAD

        _IFacturaCAD.Modificar (facturaEN);
}

public void Eliminar (int id
                      )
{
        _IFacturaCAD.Eliminar (id);
}

public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.FacturaEN> DameFacturaPedidoPago (int p_iFfactura)
{
        return _IFacturaCAD.DameFacturaPedidoPago (p_iFfactura);
}
public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.FacturaEN> DameFacturaCliente (int p_idFactura)
{
        return _IFacturaCAD.DameFacturaCliente (p_idFactura);
}
}
}
