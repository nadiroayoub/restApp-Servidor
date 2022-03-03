

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
 *      Definition of the class MovimientoCEN
 *
 */
public partial class MovimientoCEN
{
private IMovimientoCAD _IMovimientoCAD;

public MovimientoCEN()
{
        this._IMovimientoCAD = new MovimientoCAD ();
}

public MovimientoCEN(IMovimientoCAD _IMovimientoCAD)
{
        this._IMovimientoCAD = _IMovimientoCAD;
}

public IMovimientoCAD get_IMovimientoCAD ()
{
        return this._IMovimientoCAD;
}

public int Nuevo (string p_descripcion, string p_fecha, string p_cantidad, RestGenNHibernate.Enumerated.Rest.UnidadEnum p_unidad, int p_negocio)
{
        MovimientoEN movimientoEN = null;
        int oid;

        //Initialized MovimientoEN
        movimientoEN = new MovimientoEN ();
        movimientoEN.Descripcion = p_descripcion;

        movimientoEN.Fecha = p_fecha;

        movimientoEN.Cantidad = p_cantidad;

        movimientoEN.Unidad = p_unidad;


        if (p_negocio != -1) {
                // El argumento p_negocio -> Property negocio es oid = false
                // Lista de oids id
                movimientoEN.Negocio = new RestGenNHibernate.EN.Rest.NegocioEN ();
                movimientoEN.Negocio.Id = p_negocio;
        }

        //Call to MovimientoCAD

        oid = _IMovimientoCAD.Nuevo (movimientoEN);
        return oid;
}

public void Modificar (int p_Movimiento_OID, string p_descripcion, string p_fecha, string p_cantidad, RestGenNHibernate.Enumerated.Rest.UnidadEnum p_unidad)
{
        MovimientoEN movimientoEN = null;

        //Initialized MovimientoEN
        movimientoEN = new MovimientoEN ();
        movimientoEN.Id = p_Movimiento_OID;
        movimientoEN.Descripcion = p_descripcion;
        movimientoEN.Fecha = p_fecha;
        movimientoEN.Cantidad = p_cantidad;
        movimientoEN.Unidad = p_unidad;
        //Call to MovimientoCAD

        _IMovimientoCAD.Modificar (movimientoEN);
}

public void Eliminar (int id
                      )
{
        _IMovimientoCAD.Eliminar (id);
}
}
}
