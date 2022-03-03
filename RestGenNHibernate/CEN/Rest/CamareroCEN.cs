

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
 *      Definition of the class CamareroCEN
 *
 */
public partial class CamareroCEN
{
private ICamareroCAD _ICamareroCAD;

public CamareroCEN()
{
        this._ICamareroCAD = new CamareroCAD ();
}

public CamareroCEN(ICamareroCAD _ICamareroCAD)
{
        this._ICamareroCAD = _ICamareroCAD;
}

public ICamareroCAD get_ICamareroCAD ()
{
        return this._ICamareroCAD;
}

public int Nuevo ()
{
        CamareroEN camareroEN = null;
        int oid;

        //Initialized CamareroEN
        camareroEN = new CamareroEN ();
        //Call to CamareroCAD

        oid = _ICamareroCAD.Nuevo (camareroEN);
        return oid;
}

public void Modificar (int p_Camarero_OID)
{
        CamareroEN camareroEN = null;

        //Initialized CamareroEN
        camareroEN = new CamareroEN ();
        camareroEN.Id = p_Camarero_OID;
        //Call to CamareroCAD

        _ICamareroCAD.Modificar (camareroEN);
}

public void Eliminar (int id
                      )
{
        _ICamareroCAD.Eliminar (id);
}
}
}
