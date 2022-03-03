

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
 *      Definition of the class PlatoIngredienteCEN
 *
 */
public partial class PlatoIngredienteCEN
{
private IPlatoIngredienteCAD _IPlatoIngredienteCAD;

public PlatoIngredienteCEN()
{
        this._IPlatoIngredienteCAD = new PlatoIngredienteCAD ();
}

public PlatoIngredienteCEN(IPlatoIngredienteCAD _IPlatoIngredienteCAD)
{
        this._IPlatoIngredienteCAD = _IPlatoIngredienteCAD;
}

public IPlatoIngredienteCAD get_IPlatoIngredienteCAD ()
{
        return this._IPlatoIngredienteCAD;
}

public int Nuevo (double p_cantidad, int p_plato, int p_ingrediente, double p_stock)
{
        PlatoIngredienteEN platoIngredienteEN = null;
        int oid;

        //Initialized PlatoIngredienteEN
        platoIngredienteEN = new PlatoIngredienteEN ();
        platoIngredienteEN.Cantidad = p_cantidad;


        if (p_plato != -1) {
                // El argumento p_plato -> Property plato es oid = false
                // Lista de oids id
                platoIngredienteEN.Plato = new RestGenNHibernate.EN.Rest.PlatoEN ();
                platoIngredienteEN.Plato.Id = p_plato;
        }


        if (p_ingrediente != -1) {
                // El argumento p_ingrediente -> Property ingrediente es oid = false
                // Lista de oids id
                platoIngredienteEN.Ingrediente = new RestGenNHibernate.EN.Rest.IngredienteEN ();
                platoIngredienteEN.Ingrediente.Id = p_ingrediente;
        }

        platoIngredienteEN.Stock = p_stock;

        //Call to PlatoIngredienteCAD

        oid = _IPlatoIngredienteCAD.Nuevo (platoIngredienteEN);
        return oid;
}

public void Modificar (int p_PlatoIngrediente_OID, double p_cantidad, double p_stock)
{
        PlatoIngredienteEN platoIngredienteEN = null;

        //Initialized PlatoIngredienteEN
        platoIngredienteEN = new PlatoIngredienteEN ();
        platoIngredienteEN.Id = p_PlatoIngrediente_OID;
        platoIngredienteEN.Cantidad = p_cantidad;
        platoIngredienteEN.Stock = p_stock;
        //Call to PlatoIngredienteCAD

        _IPlatoIngredienteCAD.Modificar (platoIngredienteEN);
}

public void Eliminar (int id
                      )
{
        _IPlatoIngredienteCAD.Eliminar (id);
}
}
}
