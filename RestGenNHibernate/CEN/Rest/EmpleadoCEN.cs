

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
 *      Definition of the class EmpleadoCEN
 *
 */
public partial class EmpleadoCEN
{
private IEmpleadoCAD _IEmpleadoCAD;

public EmpleadoCEN()
{
        this._IEmpleadoCAD = new EmpleadoCAD ();
}

public EmpleadoCEN(IEmpleadoCAD _IEmpleadoCAD)
{
        this._IEmpleadoCAD = _IEmpleadoCAD;
}

public IEmpleadoCAD get_IEmpleadoCAD ()
{
        return this._IEmpleadoCAD;
}

public string Nuevo (string p_dni, string p_nombre, string p_apellidos, string p_telefono, int p_negocio, String p_pass)
{
        EmpleadoEN empleadoEN = null;
        string oid;

        //Initialized EmpleadoEN
        empleadoEN = new EmpleadoEN ();
        empleadoEN.Dni = p_dni;

        empleadoEN.Nombre = p_nombre;

        empleadoEN.Apellidos = p_apellidos;

        empleadoEN.Telefono = p_telefono;


        if (p_negocio != -1) {
                // El argumento p_negocio -> Property negocio es oid = false
                // Lista de oids dni
                empleadoEN.Negocio = new RestGenNHibernate.EN.Rest.NegocioEN ();
                empleadoEN.Negocio.Id = p_negocio;
        }

        empleadoEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        //Call to EmpleadoCAD

        oid = _IEmpleadoCAD.Nuevo (empleadoEN);
        return oid;
}

public void Modificar (string p_Empleado_OID, string p_nombre, string p_apellidos, string p_telefono, String p_pass)
{
        EmpleadoEN empleadoEN = null;

        //Initialized EmpleadoEN
        empleadoEN = new EmpleadoEN ();
        empleadoEN.Dni = p_Empleado_OID;
        empleadoEN.Nombre = p_nombre;
        empleadoEN.Apellidos = p_apellidos;
        empleadoEN.Telefono = p_telefono;
        empleadoEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        //Call to EmpleadoCAD

        _IEmpleadoCAD.Modificar (empleadoEN);
}

public void Eliminar (string dni
                      )
{
        _IEmpleadoCAD.Eliminar (dni);
}
}
}
