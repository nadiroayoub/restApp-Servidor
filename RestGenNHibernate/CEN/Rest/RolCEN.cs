

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
 *      Definition of the class RolCEN
 *
 */
public partial class RolCEN
{
private IRolCAD _IRolCAD;

public RolCEN()
{
        this._IRolCAD = new RolCAD ();
}

public RolCEN(IRolCAD _IRolCAD)
{
        this._IRolCAD = _IRolCAD;
}

public IRolCAD get_IRolCAD ()
{
        return this._IRolCAD;
}

public int NuevoCajero (string p_usuario)
{
        RolEN rolEN = null;
        int oid;

        //Initialized RolEN
        rolEN = new RolEN ();

        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                rolEN.Usuario = new RestGenNHibernate.EN.Rest.EmpleadoEN ();
                rolEN.Usuario.Dni = p_usuario;
        }

        //Call to RolCAD

        oid = _IRolCAD.NuevoCajero (rolEN);
        return oid;
}

public void Modificar (int p_Rol_OID)
{
        RolEN rolEN = null;

        //Initialized RolEN
        rolEN = new RolEN ();
        rolEN.Id = p_Rol_OID;
        //Call to RolCAD

        _IRolCAD.Modificar (rolEN);
}

public void Eliminar (int id
                      )
{
        _IRolCAD.Eliminar (id);
}

public int NuevoCobcinero (string p_usuario)
{
        RolEN rolEN = null;
        int oid;

        //Initialized RolEN
        rolEN = new RolEN ();

        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                rolEN.Usuario = new RestGenNHibernate.EN.Rest.EmpleadoEN ();
                rolEN.Usuario.Dni = p_usuario;
        }

        //Call to RolCAD

        oid = _IRolCAD.NuevoCobcinero (rolEN);
        return oid;
}
}
}
