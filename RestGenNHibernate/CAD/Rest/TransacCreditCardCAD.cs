
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
 * Clase TransacCreditCard:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class TransacCreditCardCAD : BasicCAD, ITransacCreditCardCAD
{
public TransacCreditCardCAD() : base ()
{
}

public TransacCreditCardCAD(ISession sessionAux) : base (sessionAux)
{
}



public TransacCreditCardEN ReadOIDDefault (int id
                                           )
{
        TransacCreditCardEN transacCreditCardEN = null;

        try
        {
                SessionInitializeTransaction ();
                transacCreditCardEN = (TransacCreditCardEN)session.Get (typeof(TransacCreditCardEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in TransacCreditCardCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return transacCreditCardEN;
}

public System.Collections.Generic.IList<TransacCreditCardEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<TransacCreditCardEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TransacCreditCardEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<TransacCreditCardEN>();
                        else
                                result = session.CreateCriteria (typeof(TransacCreditCardEN)).List<TransacCreditCardEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in TransacCreditCardCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (TransacCreditCardEN transacCreditCard)
{
        try
        {
                SessionInitializeTransaction ();
                TransacCreditCardEN transacCreditCardEN = (TransacCreditCardEN)session.Load (typeof(TransacCreditCardEN), transacCreditCard.Id);

                transacCreditCardEN.NombreOwenCard = transacCreditCard.NombreOwenCard;

                session.Update (transacCreditCardEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in TransacCreditCardCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (TransacCreditCardEN transacCreditCard)
{
        try
        {
                SessionInitializeTransaction ();
                if (transacCreditCard.Pedido != null) {
                        // Argumento OID y no colección.
                        transacCreditCard.Pedido = (RestGenNHibernate.EN.Rest.PedidoEN)session.Load (typeof(RestGenNHibernate.EN.Rest.PedidoEN), transacCreditCard.Pedido.Id);

                        transacCreditCard.Pedido.Pago
                        .Add (transacCreditCard);
                }

                session.Save (transacCreditCard);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in TransacCreditCardCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return transacCreditCard.Id;
}

public void Modificar (TransacCreditCardEN transacCreditCard)
{
        try
        {
                SessionInitializeTransaction ();
                TransacCreditCardEN transacCreditCardEN = (TransacCreditCardEN)session.Load (typeof(TransacCreditCardEN), transacCreditCard.Id);

                transacCreditCardEN.Monto = transacCreditCard.Monto;


                transacCreditCardEN.NombreOwenCard = transacCreditCard.NombreOwenCard;

                session.Update (transacCreditCardEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in TransacCreditCardCAD.", ex);
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
                TransacCreditCardEN transacCreditCardEN = (TransacCreditCardEN)session.Load (typeof(TransacCreditCardEN), id);
                session.Delete (transacCreditCardEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in TransacCreditCardCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
