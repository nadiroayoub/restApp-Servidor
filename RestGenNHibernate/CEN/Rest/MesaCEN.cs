

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
 *      Definition of the class MesaCEN
 *
 */
public partial class MesaCEN
{
private IMesaCAD _IMesaCAD;

public MesaCEN()
{
        this._IMesaCAD = new MesaCAD ();
}

public MesaCEN(IMesaCAD _IMesaCAD)
{
        this._IMesaCAD = _IMesaCAD;
}

public IMesaCAD get_IMesaCAD ()
{
        return this._IMesaCAD;
}

public int Nuevo (int p_cantidadPersonas)
{
        MesaEN mesaEN = null;
        int oid;

        //Initialized MesaEN
        mesaEN = new MesaEN ();
        mesaEN.CantidadPersonas = p_cantidadPersonas;

        //Call to MesaCAD

        oid = _IMesaCAD.Nuevo (mesaEN);
        return oid;
}

public void Modificar (int p_Mesa_OID, int p_cantidadPersonas)
{
        MesaEN mesaEN = null;

        //Initialized MesaEN
        mesaEN = new MesaEN ();
        mesaEN.Id = p_Mesa_OID;
        mesaEN.CantidadPersonas = p_cantidadPersonas;
        //Call to MesaCAD

        _IMesaCAD.Modificar (mesaEN);
}

public void Eliminar (int id
                      )
{
        _IMesaCAD.Eliminar (id);
}
}
}
