

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
 *      Definition of the class LineaProveedorCEN
 *
 */
public partial class LineaProveedorCEN
{
private ILineaProveedorCAD _ILineaProveedorCAD;

public LineaProveedorCEN()
{
        this._ILineaProveedorCAD = new LineaProveedorCAD ();
}

public LineaProveedorCEN(ILineaProveedorCAD _ILineaProveedorCAD)
{
        this._ILineaProveedorCAD = _ILineaProveedorCAD;
}

public ILineaProveedorCAD get_ILineaProveedorCAD ()
{
        return this._ILineaProveedorCAD;
}

public int Nuevo (int p_cantidad)
{
        LineaProveedorEN lineaProveedorEN = null;
        int oid;

        //Initialized LineaProveedorEN
        lineaProveedorEN = new LineaProveedorEN ();
        lineaProveedorEN.Cantidad = p_cantidad;

        //Call to LineaProveedorCAD

        oid = _ILineaProveedorCAD.Nuevo (lineaProveedorEN);
        return oid;
}

public void Modificar (int p_LineaProveedor_OID, int p_cantidad)
{
        LineaProveedorEN lineaProveedorEN = null;

        //Initialized LineaProveedorEN
        lineaProveedorEN = new LineaProveedorEN ();
        lineaProveedorEN.Id = p_LineaProveedor_OID;
        lineaProveedorEN.Cantidad = p_cantidad;
        //Call to LineaProveedorCAD

        _ILineaProveedorCAD.Modificar (lineaProveedorEN);
}

public void Eliminar (int id
                      )
{
        _ILineaProveedorCAD.Eliminar (id);
}
}
}
