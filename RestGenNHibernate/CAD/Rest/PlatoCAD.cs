
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
 * Clase Plato:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class PlatoCAD : BasicCAD, IPlatoCAD
{
public PlatoCAD() : base ()
{
}

public PlatoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PlatoEN ReadOIDDefault (int id
                               )
{
        PlatoEN platoEN = null;

        try
        {
                SessionInitializeTransaction ();
                platoEN = (PlatoEN)session.Get (typeof(PlatoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PlatoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return platoEN;
}

public System.Collections.Generic.IList<PlatoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PlatoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PlatoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PlatoEN>();
                        else
                                result = session.CreateCriteria (typeof(PlatoEN)).List<PlatoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PlatoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PlatoEN plato)
{
        try
        {
                SessionInitializeTransaction ();
                PlatoEN platoEN = (PlatoEN)session.Load (typeof(PlatoEN), plato.Id);




                platoEN.Nombre = plato.Nombre;


                platoEN.Stock = plato.Stock;

                session.Update (platoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PlatoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (PlatoEN plato)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (plato);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PlatoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return plato.Id;
}

public void Modificar (PlatoEN plato)
{
        try
        {
                SessionInitializeTransaction ();
                PlatoEN platoEN = (PlatoEN)session.Load (typeof(PlatoEN), plato.Id);

                platoEN.Nombre = plato.Nombre;


                platoEN.Stock = plato.Stock;

                session.Update (platoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PlatoCAD.", ex);
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
                PlatoEN platoEN = (PlatoEN)session.Load (typeof(PlatoEN), id);
                session.Delete (platoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PlatoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
