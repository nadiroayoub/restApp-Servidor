
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
 * Clase Bebida:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class BebidaCAD : BasicCAD, IBebidaCAD
{
public BebidaCAD() : base ()
{
}

public BebidaCAD(ISession sessionAux) : base (sessionAux)
{
}



public BebidaEN ReadOIDDefault (int id
                                )
{
        BebidaEN bebidaEN = null;

        try
        {
                SessionInitializeTransaction ();
                bebidaEN = (BebidaEN)session.Get (typeof(BebidaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in BebidaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return bebidaEN;
}

public System.Collections.Generic.IList<BebidaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<BebidaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(BebidaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<BebidaEN>();
                        else
                                result = session.CreateCriteria (typeof(BebidaEN)).List<BebidaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in BebidaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (BebidaEN bebida)
{
        try
        {
                SessionInitializeTransaction ();
                BebidaEN bebidaEN = (BebidaEN)session.Load (typeof(BebidaEN), bebida.Id);

                bebidaEN.Tipo = bebida.Tipo;


                bebidaEN.Descripcion = bebida.Descripcion;

                session.Update (bebidaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in BebidaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (BebidaEN bebida)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (bebida);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in BebidaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return bebida.Id;
}

public void Modificar (BebidaEN bebida)
{
        try
        {
                SessionInitializeTransaction ();
                BebidaEN bebidaEN = (BebidaEN)session.Load (typeof(BebidaEN), bebida.Id);

                bebidaEN.Nombre = bebida.Nombre;


                bebidaEN.Stock = bebida.Stock;


                bebidaEN.Tipo = bebida.Tipo;


                bebidaEN.Descripcion = bebida.Descripcion;

                session.Update (bebidaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in BebidaCAD.", ex);
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
                BebidaEN bebidaEN = (BebidaEN)session.Load (typeof(BebidaEN), id);
                session.Delete (bebidaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in BebidaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
