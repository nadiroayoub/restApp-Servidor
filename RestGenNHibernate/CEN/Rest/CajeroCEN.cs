

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
 *      Definition of the class CajeroCEN
 *
 */
public partial class CajeroCEN
{
private ICajeroCAD _ICajeroCAD;

public CajeroCEN()
{
        this._ICajeroCAD = new CajeroCAD ();
}

public CajeroCEN(ICajeroCAD _ICajeroCAD)
{
        this._ICajeroCAD = _ICajeroCAD;
}

public ICajeroCAD get_ICajeroCAD ()
{
        return this._ICajeroCAD;
}

public int Nuevo ()
{
        CajeroEN cajeroEN = null;
        int oid;

        //Initialized CajeroEN
        cajeroEN = new CajeroEN ();
        //Call to CajeroCAD

        oid = _ICajeroCAD.Nuevo (cajeroEN);
        return oid;
}

public void Modificar (int p_Cajero_OID)
{
        CajeroEN cajeroEN = null;

        //Initialized CajeroEN
        cajeroEN = new CajeroEN ();
        cajeroEN.Id = p_Cajero_OID;
        //Call to CajeroCAD

        _ICajeroCAD.Modificar (cajeroEN);
}

public void Eliminar (int id
                      )
{
        _ICajeroCAD.Eliminar (id);
}
}
}
