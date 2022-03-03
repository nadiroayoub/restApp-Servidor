

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
 *      Definition of the class CajaCEN
 *
 */
public partial class CajaCEN
{
private ICajaCAD _ICajaCAD;

public CajaCEN()
{
        this._ICajaCAD = new CajaCAD ();
}

public CajaCEN(ICajaCAD _ICajaCAD)
{
        this._ICajaCAD = _ICajaCAD;
}

public ICajaCAD get_ICajaCAD ()
{
        return this._ICajaCAD;
}

public int Nuevo (Nullable<DateTime> p_fecha, double p_fondo, double p_cash, double p_desfase, int p_negocio, int p_encargado)
{
        CajaEN cajaEN = null;
        int oid;

        //Initialized CajaEN
        cajaEN = new CajaEN ();
        cajaEN.Fecha = p_fecha;

        cajaEN.Fondo = p_fondo;

        cajaEN.Cash = p_cash;

        cajaEN.Desfase = p_desfase;


        if (p_negocio != -1) {
                // El argumento p_negocio -> Property negocio es oid = false
                // Lista de oids id
                cajaEN.Negocio = new RestGenNHibernate.EN.Rest.NegocioEN ();
                cajaEN.Negocio.Id = p_negocio;
        }


        if (p_encargado != -1) {
                // El argumento p_encargado -> Property encargado es oid = false
                // Lista de oids id
                cajaEN.Encargado = new RestGenNHibernate.EN.Rest.EncargadoEN ();
                cajaEN.Encargado.Id = p_encargado;
        }

        //Call to CajaCAD

        oid = _ICajaCAD.Nuevo (cajaEN);
        return oid;
}

public void Modificar (int p_Caja_OID, Nullable<DateTime> p_fecha, double p_fondo, double p_cash, double p_desfase)
{
        CajaEN cajaEN = null;

        //Initialized CajaEN
        cajaEN = new CajaEN ();
        cajaEN.Id = p_Caja_OID;
        cajaEN.Fecha = p_fecha;
        cajaEN.Fondo = p_fondo;
        cajaEN.Cash = p_cash;
        cajaEN.Desfase = p_desfase;
        //Call to CajaCAD

        _ICajaCAD.Modificar (cajaEN);
}

public void Eliminar (int id
                      )
{
        _ICajaCAD.Eliminar (id);
}

public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.CajaEN> OperacionesCaja (Nullable<DateTime> p_fecha)
{
        return _ICajaCAD.OperacionesCaja (p_fecha);
}
}
}
