

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
 *      Definition of the class MenuCEN
 *
 */
public partial class MenuCEN
{
private IMenuCAD _IMenuCAD;

public MenuCEN()
{
        this._IMenuCAD = new MenuCAD ();
}

public MenuCEN(IMenuCAD _IMenuCAD)
{
        this._IMenuCAD = _IMenuCAD;
}

public IMenuCAD get_IMenuCAD ()
{
        return this._IMenuCAD;
}

public int Nuevo (string p_nombre, int p_stock)
{
        MenuEN menuEN = null;
        int oid;

        //Initialized MenuEN
        menuEN = new MenuEN ();
        menuEN.Nombre = p_nombre;

        menuEN.Stock = p_stock;

        //Call to MenuCAD

        oid = _IMenuCAD.Nuevo (menuEN);
        return oid;
}

public void Modificar (int p_Menu_OID, string p_nombre, int p_stock)
{
        MenuEN menuEN = null;

        //Initialized MenuEN
        menuEN = new MenuEN ();
        menuEN.Id = p_Menu_OID;
        menuEN.Nombre = p_nombre;
        menuEN.Stock = p_stock;
        //Call to MenuCAD

        _IMenuCAD.Modificar (menuEN);
}

public void Eliminar (int id
                      )
{
        _IMenuCAD.Eliminar (id);
}
}
}
