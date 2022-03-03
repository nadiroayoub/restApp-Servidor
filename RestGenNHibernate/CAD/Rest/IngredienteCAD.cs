
using System;
using System.Text;
using RestGenNHibernate.CEN.Rest;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using RestGenNHibernate.EN.Rest;
using RestGenNHibernate.Exceptions;


/*
 * Clase Ingrediente:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class IngredienteCAD : BasicCAD, IIngredienteCAD
{
public IngredienteCAD() : base ()
{
}

public IngredienteCAD(ISession sessionAux) : base (sessionAux)
{
}



public IngredienteEN ReadOIDDefault (int id
                                     )
{
        IngredienteEN ingredienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                ingredienteEN = (IngredienteEN)session.Get (typeof(IngredienteEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ingredienteEN;
}

public System.Collections.Generic.IList<IngredienteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IngredienteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IngredienteEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IngredienteEN>();
                        else
                                result = session.CreateCriteria (typeof(IngredienteEN)).List<IngredienteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IngredienteEN ingrediente)
{
        try
        {
                SessionInitializeTransaction ();
                IngredienteEN ingredienteEN = (IngredienteEN)session.Load (typeof(IngredienteEN), ingrediente.Id);


                ingredienteEN.CantidadStock = ingrediente.CantidadStock;


                ingredienteEN.UnidadMedida = ingrediente.UnidadMedida;



                session.Update (ingredienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (IngredienteEN ingrediente)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (ingrediente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ingrediente.Id;
}

public void Modificar (IngredienteEN ingrediente)
{
        try
        {
                SessionInitializeTransaction ();
                IngredienteEN ingredienteEN = (IngredienteEN)session.Load (typeof(IngredienteEN), ingrediente.Id);

                ingredienteEN.CantidadStock = ingrediente.CantidadStock;


                ingredienteEN.UnidadMedida = ingrediente.UnidadMedida;

                session.Update (ingredienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int id
                      )
{
        try
        {
                SessionInitializeTransaction ();
                IngredienteEN ingredienteEN = (IngredienteEN)session.Load (typeof(IngredienteEN), id);
                session.Delete (ingredienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.IngredienteEN> DameIngredienteProveedor ()
{
        System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.IngredienteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM IngredienteEN self where select serv FROM IngredienteEN as serv inner join serv.LineaProveedor as linProv where linProv.Id =: p_idProveedor";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("IngredienteENDameIngredienteProveedorHQL");

                result = query.List<RestGenNHibernate.EN.Rest.IngredienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.IngredienteEN> DameIngredientePlato (int p_idePlato)
{
        System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.IngredienteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM IngredienteEN self where select ing FROM IngredienteEN as ing inner join ing.PlatoIngrediente as plato where plato.Id=: p_idPlato";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("IngredienteENDameIngredientePlatoHQL");
                query.SetParameter ("p_idePlato", p_idePlato);

                result = query.List<RestGenNHibernate.EN.Rest.IngredienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in IngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
