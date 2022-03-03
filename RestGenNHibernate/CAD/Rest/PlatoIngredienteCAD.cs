
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
 * Clase PlatoIngrediente:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class PlatoIngredienteCAD : BasicCAD, IPlatoIngredienteCAD
{
public PlatoIngredienteCAD() : base ()
{
}

public PlatoIngredienteCAD(ISession sessionAux) : base (sessionAux)
{
}



public PlatoIngredienteEN ReadOIDDefault (int id
                                          )
{
        PlatoIngredienteEN platoIngredienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                platoIngredienteEN = (PlatoIngredienteEN)session.Get (typeof(PlatoIngredienteEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PlatoIngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return platoIngredienteEN;
}

public System.Collections.Generic.IList<PlatoIngredienteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PlatoIngredienteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PlatoIngredienteEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PlatoIngredienteEN>();
                        else
                                result = session.CreateCriteria (typeof(PlatoIngredienteEN)).List<PlatoIngredienteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PlatoIngredienteCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PlatoIngredienteEN platoIngrediente)
{
        try
        {
                SessionInitializeTransaction ();
                PlatoIngredienteEN platoIngredienteEN = (PlatoIngredienteEN)session.Load (typeof(PlatoIngredienteEN), platoIngrediente.Id);

                platoIngredienteEN.Cantidad = platoIngrediente.Cantidad;




                platoIngredienteEN.Stock = platoIngrediente.Stock;

                session.Update (platoIngredienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PlatoIngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (PlatoIngredienteEN platoIngrediente)
{
        try
        {
                SessionInitializeTransaction ();
                if (platoIngrediente.Plato != null) {
                        // Argumento OID y no colección.
                        platoIngrediente.Plato = (RestGenNHibernate.EN.Rest.PlatoEN)session.Load (typeof(RestGenNHibernate.EN.Rest.PlatoEN), platoIngrediente.Plato.Id);

                        platoIngrediente.Plato.PlatoIngrediente
                        .Add (platoIngrediente);
                }
                if (platoIngrediente.Ingrediente != null) {
                        // Argumento OID y no colección.
                        platoIngrediente.Ingrediente = (RestGenNHibernate.EN.Rest.IngredienteEN)session.Load (typeof(RestGenNHibernate.EN.Rest.IngredienteEN), platoIngrediente.Ingrediente.Id);

                        platoIngrediente.Ingrediente.PlatoIngrediente
                        .Add (platoIngrediente);
                }

                session.Save (platoIngrediente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PlatoIngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return platoIngrediente.Id;
}

public void Modificar (PlatoIngredienteEN platoIngrediente)
{
        try
        {
                SessionInitializeTransaction ();
                PlatoIngredienteEN platoIngredienteEN = (PlatoIngredienteEN)session.Load (typeof(PlatoIngredienteEN), platoIngrediente.Id);

                platoIngredienteEN.Cantidad = platoIngrediente.Cantidad;


                platoIngredienteEN.Stock = platoIngrediente.Stock;

                session.Update (platoIngredienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PlatoIngredienteCAD.", ex);
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
                PlatoIngredienteEN platoIngredienteEN = (PlatoIngredienteEN)session.Load (typeof(PlatoIngredienteEN), id);
                session.Delete (platoIngredienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PlatoIngredienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
