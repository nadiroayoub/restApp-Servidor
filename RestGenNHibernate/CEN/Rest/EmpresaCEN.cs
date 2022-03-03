

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
 *      Definition of the class EmpresaCEN
 *
 */
public partial class EmpresaCEN
{
private IEmpresaCAD _IEmpresaCAD;

public EmpresaCEN()
{
        this._IEmpresaCAD = new EmpresaCAD ();
}

public EmpresaCEN(IEmpresaCAD _IEmpresaCAD)
{
        this._IEmpresaCAD = _IEmpresaCAD;
}

public IEmpresaCAD get_IEmpresaCAD ()
{
        return this._IEmpresaCAD;
}

public int Nuevo (string p_nombre, string p_direccion, System.Collections.Generic.IList<int> p_negocio)
{
        EmpresaEN empresaEN = null;
        int oid;

        //Initialized EmpresaEN
        empresaEN = new EmpresaEN ();
        empresaEN.Nombre = p_nombre;

        empresaEN.Direccion = p_direccion;


        empresaEN.Negocio = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.NegocioEN>();
        if (p_negocio != null) {
                foreach (int item in p_negocio) {
                        RestGenNHibernate.EN.Rest.NegocioEN en = new RestGenNHibernate.EN.Rest.NegocioEN ();
                        en.Id = item;
                        empresaEN.Negocio.Add (en);
                }
        }

        else{
                empresaEN.Negocio = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.NegocioEN>();
        }

        //Call to EmpresaCAD

        oid = _IEmpresaCAD.Nuevo (empresaEN);
        return oid;
}

public void Modificar (int p_Empresa_OID, string p_nombre, string p_direccion)
{
        EmpresaEN empresaEN = null;

        //Initialized EmpresaEN
        empresaEN = new EmpresaEN ();
        empresaEN.Id = p_Empresa_OID;
        empresaEN.Nombre = p_nombre;
        empresaEN.Direccion = p_direccion;
        //Call to EmpresaCAD

        _IEmpresaCAD.Modificar (empresaEN);
}

public void Eliminar (int id
                      )
{
        _IEmpresaCAD.Eliminar (id);
}

public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.EmpresaEN> DameNegocio ()
{
        return _IEmpresaCAD.DameNegocio ();
}
}
}
