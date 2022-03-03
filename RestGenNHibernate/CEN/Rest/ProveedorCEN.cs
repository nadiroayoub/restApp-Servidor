

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
 *      Definition of the class ProveedorCEN
 *
 */
public partial class ProveedorCEN
{
private IProveedorCAD _IProveedorCAD;

public ProveedorCEN()
{
        this._IProveedorCAD = new ProveedorCAD ();
}

public ProveedorCEN(IProveedorCAD _IProveedorCAD)
{
        this._IProveedorCAD = _IProveedorCAD;
}

public IProveedorCAD get_IProveedorCAD ()
{
        return this._IProveedorCAD;
}

public int Nuevo (string p_nombre, string p_numeroTelefono, RestGenNHibernate.Enumerated.Rest.TipoProveedorEnum p_direccion, RestGenNHibernate.Enumerated.Rest.TipoProveedorEnum p_tipo)
{
        ProveedorEN proveedorEN = null;
        int oid;

        //Initialized ProveedorEN
        proveedorEN = new ProveedorEN ();
        proveedorEN.Nombre = p_nombre;

        proveedorEN.NumeroTelefono = p_numeroTelefono;

        proveedorEN.Direccion = p_direccion;

        proveedorEN.Tipo = p_tipo;

        //Call to ProveedorCAD

        oid = _IProveedorCAD.Nuevo (proveedorEN);
        return oid;
}

public void Modificar (int p_Proveedor_OID, string p_nombre, string p_numeroTelefono, RestGenNHibernate.Enumerated.Rest.TipoProveedorEnum p_direccion, RestGenNHibernate.Enumerated.Rest.TipoProveedorEnum p_tipo)
{
        ProveedorEN proveedorEN = null;

        //Initialized ProveedorEN
        proveedorEN = new ProveedorEN ();
        proveedorEN.Id = p_Proveedor_OID;
        proveedorEN.Nombre = p_nombre;
        proveedorEN.NumeroTelefono = p_numeroTelefono;
        proveedorEN.Direccion = p_direccion;
        proveedorEN.Tipo = p_tipo;
        //Call to ProveedorCAD

        _IProveedorCAD.Modificar (proveedorEN);
}

public void Eliminar (int id
                      )
{
        _IProveedorCAD.Eliminar (id);
}
}
}
