

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
 *      Definition of the class DueñoCEN
 *
 */
public partial class DueñoCEN
{
private IDueñoCAD _IDueñoCAD;

public DueñoCEN()
{
        this._IDueñoCAD = new DueñoCAD ();
}

public DueñoCEN(IDueñoCAD _IDueñoCAD)
{
        this._IDueñoCAD = _IDueñoCAD;
}

public IDueñoCAD get_IDueñoCAD ()
{
        return this._IDueñoCAD;
}

public int Nuevo (string p_nombre, string p_apellido, string p_telefono, String p_pass)
{
        DueñoEN dueñoEN = null;
        int oid;

        //Initialized DueñoEN
        dueñoEN = new DueñoEN ();
        dueñoEN.Nombre = p_nombre;

        dueñoEN.Apellido = p_apellido;

        dueñoEN.Telefono = p_telefono;

        dueñoEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        //Call to DueñoCAD

        oid = _IDueñoCAD.Nuevo (dueñoEN);
        return oid;
}

public void Modificar (int p_Dueño_OID, string p_nombre, string p_apellido, string p_telefono, String p_pass)
{
        DueñoEN dueñoEN = null;

        //Initialized DueñoEN
        dueñoEN = new DueñoEN ();
        dueñoEN.Dni = p_Dueño_OID;
        dueñoEN.Nombre = p_nombre;
        dueñoEN.Apellido = p_apellido;
        dueñoEN.Telefono = p_telefono;
        dueñoEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        //Call to DueñoCAD

        _IDueñoCAD.Modificar (dueñoEN);
}

public void Eliminar (int dni
                      )
{
        _IDueñoCAD.Eliminar (dni);
}
}
}
