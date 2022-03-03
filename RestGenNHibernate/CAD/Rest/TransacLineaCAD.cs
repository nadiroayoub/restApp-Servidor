
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
 * Clase TransacLinea:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class TransacLineaCAD : BasicCAD, ITransacLineaCAD
{
public TransacLineaCAD() : base ()
{
}

public TransacLineaCAD(ISession sessionAux) : base (sessionAux)
{
}



public TransacLineaEN ReadOIDDefault (int id
                                      )
{
        TransacLineaEN transacLineaEN = null;

        try
        {
                SessionInitializeTransaction ();
                transacLineaEN = (TransacLineaEN)session.Get (typeof(TransacLineaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in TransacLineaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return transacLineaEN;
}

public System.Collections.Generic.IList<TransacLineaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<TransacLineaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TransacLineaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<TransacLineaEN>();
                        else
                                result = session.CreateCriteria (typeof(TransacLineaEN)).List<TransacLineaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in TransacLineaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (TransacLineaEN transacLinea)
{
        try
        {
                SessionInitializeTransaction ();
                TransacLineaEN transacLineaEN = (TransacLineaEN)session.Load (typeof(TransacLineaEN), transacLinea.Id);

                transacLineaEN.Nombre = transacLinea.Nombre;


                transacLineaEN.Numero = transacLinea.Numero;

                session.Update (transacLineaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in TransacLineaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (TransacLineaEN transacLinea)
{
        try
        {
                SessionInitializeTransaction ();
                if (transacLinea.Pedido != null) {
                        // Argumento OID y no colección.
                        transacLinea.Pedido = (RestGenNHibernate.EN.Rest.PedidoEN)session.Load (typeof(RestGenNHibernate.EN.Rest.PedidoEN), transacLinea.Pedido.Id);

                        transacLinea.Pedido.Pago
                        .Add (transacLinea);
                }

                session.Save (transacLinea);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in TransacLineaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return transacLinea.Id;
}

public void Modificar (TransacLineaEN transacLinea)
{
        try
        {
                SessionInitializeTransaction ();
                TransacLineaEN transacLineaEN = (TransacLineaEN)session.Load (typeof(TransacLineaEN), transacLinea.Id);

                transacLineaEN.Monto = transacLinea.Monto;


                transacLineaEN.Nombre = transacLinea.Nombre;


                transacLineaEN.Numero = transacLinea.Numero;

                session.Update (transacLineaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in TransacLineaCAD.", ex);
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
                TransacLineaEN transacLineaEN = (TransacLineaEN)session.Load (typeof(TransacLineaEN), id);
                session.Delete (transacLineaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in TransacLineaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
