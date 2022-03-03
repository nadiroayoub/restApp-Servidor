
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
 * Clase Pago:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class PagoCAD : BasicCAD, IPagoCAD
{
public PagoCAD() : base ()
{
}

public PagoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PagoEN ReadOIDDefault (int id
                              )
{
        PagoEN pagoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pagoEN = (PagoEN)session.Get (typeof(PagoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pagoEN;
}

public System.Collections.Generic.IList<PagoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PagoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PagoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PagoEN>();
                        else
                                result = session.CreateCriteria (typeof(PagoEN)).List<PagoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PagoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PagoEN pago)
{
        try
        {
                SessionInitializeTransaction ();
                PagoEN pagoEN = (PagoEN)session.Load (typeof(PagoEN), pago.Id);

                pagoEN.Monto = pago.Monto;



                session.Update (pagoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (PagoEN pago)
{
        try
        {
                SessionInitializeTransaction ();
                if (pago.Pedido != null) {
                        // Argumento OID y no colección.
                        pago.Pedido = (RestGenNHibernate.EN.Rest.PedidoEN)session.Load (typeof(RestGenNHibernate.EN.Rest.PedidoEN), pago.Pedido.Id);

                        pago.Pedido.Pago
                        .Add (pago);
                }

                session.Save (pago);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pago.Id;
}

public void Modificar (PagoEN pago)
{
        try
        {
                SessionInitializeTransaction ();
                PagoEN pagoEN = (PagoEN)session.Load (typeof(PagoEN), pago.Id);

                pagoEN.Monto = pago.Monto;

                session.Update (pagoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PagoCAD.", ex);
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
                PagoEN pagoEN = (PagoEN)session.Load (typeof(PagoEN), id);
                session.Delete (pagoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PagoEN> DamePagos ()
{
        System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PagoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PagoEN self where FROM PagoEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PagoENDamePagosHQL");

                result = query.List<RestGenNHibernate.EN.Rest.PagoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
