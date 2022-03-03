

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
 *      Definition of the class IngredienteCEN
 *
 */
public partial class IngredienteCEN
{
private IIngredienteCAD _IIngredienteCAD;

public IngredienteCEN()
{
        this._IIngredienteCAD = new IngredienteCAD ();
}

public IngredienteCEN(IIngredienteCAD _IIngredienteCAD)
{
        this._IIngredienteCAD = _IIngredienteCAD;
}

public IIngredienteCAD get_IIngredienteCAD ()
{
        return this._IIngredienteCAD;
}

public int Nuevo (double p_cantidadStock, RestGenNHibernate.Enumerated.Rest.UnidadEnum p_unidadMedida)
{
        IngredienteEN ingredienteEN = null;
        int oid;

        //Initialized IngredienteEN
        ingredienteEN = new IngredienteEN ();
        ingredienteEN.CantidadStock = p_cantidadStock;

        ingredienteEN.UnidadMedida = p_unidadMedida;

        //Call to IngredienteCAD

        oid = _IIngredienteCAD.Nuevo (ingredienteEN);
        return oid;
}

public void Modificar (int p_Ingrediente_OID, double p_cantidadStock, RestGenNHibernate.Enumerated.Rest.UnidadEnum p_unidadMedida)
{
        IngredienteEN ingredienteEN = null;

        //Initialized IngredienteEN
        ingredienteEN = new IngredienteEN ();
        ingredienteEN.Id = p_Ingrediente_OID;
        ingredienteEN.CantidadStock = p_cantidadStock;
        ingredienteEN.UnidadMedida = p_unidadMedida;
        //Call to IngredienteCAD

        _IIngredienteCAD.Modificar (ingredienteEN);
}

public void Eliminar (int id
                      )
{
        _IIngredienteCAD.Eliminar (id);
}

public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.IngredienteEN> DameIngredienteProveedor ()
{
        return _IIngredienteCAD.DameIngredienteProveedor ();
}
public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.IngredienteEN> DameIngredientePlato (int p_idePlato)
{
        return _IIngredienteCAD.DameIngredientePlato (p_idePlato);
}
}
}
