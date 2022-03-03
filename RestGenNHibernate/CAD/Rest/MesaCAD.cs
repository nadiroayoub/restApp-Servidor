
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
 * Clase Mesa:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class MesaCAD : BasicCAD, IMesaCAD
{
public MesaCAD() : base ()
{
}

public MesaCAD(ISession sessionAux) : base (sessionAux)
{
}



public MesaEN ReadOIDDefault (int id
                              )
{
        MesaEN mesaEN = null;

        try
        {
                SessionInitializeTransaction ();
                mesaEN = (MesaEN)session.Get (typeof(MesaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in MesaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mesaEN;
}

public System.Collections.Generic.IList<MesaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MesaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MesaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MesaEN>();
                        else
                                result = session.CreateCriteria (typeof(MesaEN)).List<MesaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in MesaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MesaEN mesa)
{
        try
        {
                SessionInitializeTransaction ();
                MesaEN mesaEN = (MesaEN)session.Load (typeof(MesaEN), mesa.Id);

                mesaEN.CantidadPersonas = mesa.CantidadPersonas;




                session.Update (mesaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in MesaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (MesaEN mesa)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (mesa);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in MesaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mesa.Id;
}

public void Modificar (MesaEN mesa)
{
        try
        {
                SessionInitializeTransaction ();
                MesaEN mesaEN = (MesaEN)session.Load (typeof(MesaEN), mesa.Id);

                mesaEN.CantidadPersonas = mesa.CantidadPersonas;

                session.Update (mesaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in MesaCAD.", ex);
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
                MesaEN mesaEN = (MesaEN)session.Load (typeof(MesaEN), id);
                session.Delete (mesaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in MesaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
