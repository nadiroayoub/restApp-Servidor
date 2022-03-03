

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
 *      Definition of the class PlatoCEN
 *
 */
public partial class PlatoCEN
{
private IPlatoCAD _IPlatoCAD;

public PlatoCEN()
{
        this._IPlatoCAD = new PlatoCAD ();
}

public PlatoCEN(IPlatoCAD _IPlatoCAD)
{
        this._IPlatoCAD = _IPlatoCAD;
}

public IPlatoCAD get_IPlatoCAD ()
{
        return this._IPlatoCAD;
}

public int Nuevo (string p_nombre, int p_stock)
{
        PlatoEN platoEN = null;
        int oid;

        //Initialized PlatoEN
        platoEN = new PlatoEN ();
        platoEN.Nombre = p_nombre;

        platoEN.Stock = p_stock;

        //Call to PlatoCAD

        oid = _IPlatoCAD.Nuevo (platoEN);
        return oid;
}

public void Modificar (int p_Plato_OID, string p_nombre, int p_stock)
{
        PlatoEN platoEN = null;

        //Initialized PlatoEN
        platoEN = new PlatoEN ();
        platoEN.Id = p_Plato_OID;
        platoEN.Nombre = p_nombre;
        platoEN.Stock = p_stock;
        //Call to PlatoCAD

        _IPlatoCAD.Modificar (platoEN);
}

public void Eliminar (int id
                      )
{
        _IPlatoCAD.Eliminar (id);
}
}
}
