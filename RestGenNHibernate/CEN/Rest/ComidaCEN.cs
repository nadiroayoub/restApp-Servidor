

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
 *      Definition of the class ComidaCEN
 *
 */
public partial class ComidaCEN
{
private IComidaCAD _IComidaCAD;

public ComidaCEN()
{
        this._IComidaCAD = new ComidaCAD ();
}

public ComidaCEN(IComidaCAD _IComidaCAD)
{
        this._IComidaCAD = _IComidaCAD;
}

public IComidaCAD get_IComidaCAD ()
{
        return this._IComidaCAD;
}

public int Nuevo (string p_nombre, int p_stock, string p_descripcion, string p_informacionCalorica)
{
        ComidaEN comidaEN = null;
        int oid;

        //Initialized ComidaEN
        comidaEN = new ComidaEN ();
        comidaEN.Nombre = p_nombre;

        comidaEN.Stock = p_stock;

        comidaEN.Descripcion = p_descripcion;

        comidaEN.InformacionCalorica = p_informacionCalorica;

        //Call to ComidaCAD

        oid = _IComidaCAD.Nuevo (comidaEN);
        return oid;
}

public void Modificar (int p_Comida_OID, string p_nombre, int p_stock, string p_descripcion, string p_informacionCalorica)
{
        ComidaEN comidaEN = null;

        //Initialized ComidaEN
        comidaEN = new ComidaEN ();
        comidaEN.Id = p_Comida_OID;
        comidaEN.Nombre = p_nombre;
        comidaEN.Stock = p_stock;
        comidaEN.Descripcion = p_descripcion;
        comidaEN.InformacionCalorica = p_informacionCalorica;
        //Call to ComidaCAD

        _IComidaCAD.Modificar (comidaEN);
}

public void Eliminar (int id
                      )
{
        _IComidaCAD.Eliminar (id);
}
}
}
