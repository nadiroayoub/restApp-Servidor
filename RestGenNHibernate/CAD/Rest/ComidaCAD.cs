
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
 * Clase Comida:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class ComidaCAD : BasicCAD, IComidaCAD
{
public ComidaCAD() : base ()
{
}

public ComidaCAD(ISession sessionAux) : base (sessionAux)
{
}



public ComidaEN ReadOIDDefault (int id
                                )
{
        ComidaEN comidaEN = null;

        try
        {
                SessionInitializeTransaction ();
                comidaEN = (ComidaEN)session.Get (typeof(ComidaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ComidaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comidaEN;
}

public System.Collections.Generic.IList<ComidaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ComidaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ComidaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ComidaEN>();
                        else
                                result = session.CreateCriteria (typeof(ComidaEN)).List<ComidaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ComidaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ComidaEN comida)
{
        try
        {
                SessionInitializeTransaction ();
                ComidaEN comidaEN = (ComidaEN)session.Load (typeof(ComidaEN), comida.Id);

                comidaEN.Descripcion = comida.Descripcion;


                comidaEN.InformacionCalorica = comida.InformacionCalorica;

                session.Update (comidaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ComidaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (ComidaEN comida)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (comida);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ComidaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comida.Id;
}

public void Modificar (ComidaEN comida)
{
        try
        {
                SessionInitializeTransaction ();
                ComidaEN comidaEN = (ComidaEN)session.Load (typeof(ComidaEN), comida.Id);

                comidaEN.Nombre = comida.Nombre;


                comidaEN.Stock = comida.Stock;


                comidaEN.Descripcion = comida.Descripcion;


                comidaEN.InformacionCalorica = comida.InformacionCalorica;

                session.Update (comidaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ComidaCAD.", ex);
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
                ComidaEN comidaEN = (ComidaEN)session.Load (typeof(ComidaEN), id);
                session.Delete (comidaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ComidaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
