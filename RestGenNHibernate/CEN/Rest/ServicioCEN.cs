

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
 *      Definition of the class ServicioCEN
 *
 */
public partial class ServicioCEN
{
private IServicioCAD _IServicioCAD;

public ServicioCEN()
{
        this._IServicioCAD = new ServicioCAD ();
}

public ServicioCEN(IServicioCAD _IServicioCAD)
{
        this._IServicioCAD = _IServicioCAD;
}

public IServicioCAD get_IServicioCAD ()
{
        return this._IServicioCAD;
}

public int Nuevo (RestGenNHibernate.Enumerated.Rest.TipoServicioEnum p_tipo, Nullable<DateTime> p_fecha, int p_negocio, string p_nombre, double p_monto)
{
        ServicioEN servicioEN = null;
        int oid;

        //Initialized ServicioEN
        servicioEN = new ServicioEN ();
        servicioEN.Tipo = p_tipo;

        servicioEN.Fecha = p_fecha;


        if (p_negocio != -1) {
                // El argumento p_negocio -> Property negocio es oid = false
                // Lista de oids id
                servicioEN.Negocio = new RestGenNHibernate.EN.Rest.NegocioEN ();
                servicioEN.Negocio.Id = p_negocio;
        }

        servicioEN.Nombre = p_nombre;

        servicioEN.Monto = p_monto;

        //Call to ServicioCAD

        oid = _IServicioCAD.Nuevo (servicioEN);
        return oid;
}

public void Modificar (int p_Servicio_OID, RestGenNHibernate.Enumerated.Rest.TipoServicioEnum p_tipo, Nullable<DateTime> p_fecha, string p_nombre, double p_monto)
{
        ServicioEN servicioEN = null;

        //Initialized ServicioEN
        servicioEN = new ServicioEN ();
        servicioEN.Id = p_Servicio_OID;
        servicioEN.Tipo = p_tipo;
        servicioEN.Fecha = p_fecha;
        servicioEN.Nombre = p_nombre;
        servicioEN.Monto = p_monto;
        //Call to ServicioCAD

        _IServicioCAD.Modificar (servicioEN);
}

public void Eliminar (int id
                      )
{
        _IServicioCAD.Eliminar (id);
}
}
}
