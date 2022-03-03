
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
 * Clase Encargado:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class EncargadoCAD : BasicCAD, IEncargadoCAD
{
public EncargadoCAD() : base ()
{
}

public EncargadoCAD(ISession sessionAux) : base (sessionAux)
{
}



public EncargadoEN ReadOIDDefault (int id
                                   )
{
        EncargadoEN encargadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                encargadoEN = (EncargadoEN)session.Get (typeof(EncargadoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EncargadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return encargadoEN;
}

public System.Collections.Generic.IList<EncargadoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EncargadoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EncargadoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EncargadoEN>();
                        else
                                result = session.CreateCriteria (typeof(EncargadoEN)).List<EncargadoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EncargadoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EncargadoEN encargado)
{
        try
        {
                SessionInitializeTransaction ();
                EncargadoEN encargadoEN = (EncargadoEN)session.Load (typeof(EncargadoEN), encargado.Id);


                session.Update (encargadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EncargadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (EncargadoEN encargado)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (encargado);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EncargadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return encargado.Id;
}

public void Modificar (EncargadoEN encargado)
{
        try
        {
                SessionInitializeTransaction ();
                EncargadoEN encargadoEN = (EncargadoEN)session.Load (typeof(EncargadoEN), encargado.Id);
                session.Update (encargadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EncargadoCAD.", ex);
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
                EncargadoEN encargadoEN = (EncargadoEN)session.Load (typeof(EncargadoEN), id);
                session.Delete (encargadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EncargadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
