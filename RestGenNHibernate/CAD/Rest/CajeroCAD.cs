
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
 * Clase Cajero:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class CajeroCAD : BasicCAD, ICajeroCAD
{
public CajeroCAD() : base ()
{
}

public CajeroCAD(ISession sessionAux) : base (sessionAux)
{
}



public CajeroEN ReadOIDDefault (int id
                                )
{
        CajeroEN cajeroEN = null;

        try
        {
                SessionInitializeTransaction ();
                cajeroEN = (CajeroEN)session.Get (typeof(CajeroEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in CajeroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cajeroEN;
}

public System.Collections.Generic.IList<CajeroEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CajeroEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CajeroEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CajeroEN>();
                        else
                                result = session.CreateCriteria (typeof(CajeroEN)).List<CajeroEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in CajeroCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CajeroEN cajero)
{
        try
        {
                SessionInitializeTransaction ();
                CajeroEN cajeroEN = (CajeroEN)session.Load (typeof(CajeroEN), cajero.Id);

                session.Update (cajeroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in CajeroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (CajeroEN cajero)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (cajero);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in CajeroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cajero.Id;
}

public void Modificar (CajeroEN cajero)
{
        try
        {
                SessionInitializeTransaction ();
                CajeroEN cajeroEN = (CajeroEN)session.Load (typeof(CajeroEN), cajero.Id);
                session.Update (cajeroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in CajeroCAD.", ex);
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
                CajeroEN cajeroEN = (CajeroEN)session.Load (typeof(CajeroEN), id);
                session.Delete (cajeroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in CajeroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
