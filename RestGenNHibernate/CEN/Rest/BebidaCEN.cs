

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
 *      Definition of the class BebidaCEN
 *
 */
public partial class BebidaCEN
{
private IBebidaCAD _IBebidaCAD;

public BebidaCEN()
{
        this._IBebidaCAD = new BebidaCAD ();
}

public BebidaCEN(IBebidaCAD _IBebidaCAD)
{
        this._IBebidaCAD = _IBebidaCAD;
}

public IBebidaCAD get_IBebidaCAD ()
{
        return this._IBebidaCAD;
}

public int Nuevo (string p_nombre, int p_stock, RestGenNHibernate.Enumerated.Rest.TipoBebidaEnum p_tipo, string p_descripcion)
{
        BebidaEN bebidaEN = null;
        int oid;

        //Initialized BebidaEN
        bebidaEN = new BebidaEN ();
        bebidaEN.Nombre = p_nombre;

        bebidaEN.Stock = p_stock;

        bebidaEN.Tipo = p_tipo;

        bebidaEN.Descripcion = p_descripcion;

        //Call to BebidaCAD

        oid = _IBebidaCAD.Nuevo (bebidaEN);
        return oid;
}

public void Modificar (int p_Bebida_OID, string p_nombre, int p_stock, RestGenNHibernate.Enumerated.Rest.TipoBebidaEnum p_tipo, string p_descripcion)
{
        BebidaEN bebidaEN = null;

        //Initialized BebidaEN
        bebidaEN = new BebidaEN ();
        bebidaEN.Id = p_Bebida_OID;
        bebidaEN.Nombre = p_nombre;
        bebidaEN.Stock = p_stock;
        bebidaEN.Tipo = p_tipo;
        bebidaEN.Descripcion = p_descripcion;
        //Call to BebidaCAD

        _IBebidaCAD.Modificar (bebidaEN);
}

public void Eliminar (int id
                      )
{
        _IBebidaCAD.Eliminar (id);
}
}
}
