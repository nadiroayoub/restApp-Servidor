
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
 * Clase PedidoProveedor:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class PedidoProveedorCAD : BasicCAD, IPedidoProveedorCAD
{
public PedidoProveedorCAD() : base ()
{
}

public PedidoProveedorCAD(ISession sessionAux) : base (sessionAux)
{
}



public PedidoProveedorEN ReadOIDDefault (int id
                                         )
{
        PedidoProveedorEN pedidoProveedorEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoProveedorEN = (PedidoProveedorEN)session.Get (typeof(PedidoProveedorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoProveedorEN;
}

public System.Collections.Generic.IList<PedidoProveedorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PedidoProveedorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PedidoProveedorEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PedidoProveedorEN>();
                        else
                                result = session.CreateCriteria (typeof(PedidoProveedorEN)).List<PedidoProveedorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PedidoProveedorEN pedidoProveedor)
{
        try
        {
                SessionInitializeTransaction ();
                PedidoProveedorEN pedidoProveedorEN = (PedidoProveedorEN)session.Load (typeof(PedidoProveedorEN), pedidoProveedor.Id);



                session.Update (pedidoProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (PedidoProveedorEN pedidoProveedor)
{
        try
        {
                SessionInitializeTransaction ();
                if (pedidoProveedor.Proveedor != null) {
                        // Argumento OID y no colección.
                        pedidoProveedor.Proveedor = (RestGenNHibernate.EN.Rest.ProveedorEN)session.Load (typeof(RestGenNHibernate.EN.Rest.ProveedorEN), pedidoProveedor.Proveedor.Id);

                        pedidoProveedor.Proveedor.PedidoProveedor
                        .Add (pedidoProveedor);
                }
                if (pedidoProveedor.Negocio != null) {
                        // Argumento OID y no colección.
                        pedidoProveedor.Negocio = (RestGenNHibernate.EN.Rest.NegocioEN)session.Load (typeof(RestGenNHibernate.EN.Rest.NegocioEN), pedidoProveedor.Negocio.Id);

                        pedidoProveedor.Negocio.PedidoProveedor
                        .Add (pedidoProveedor);
                }

                session.Save (pedidoProveedor);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoProveedor.Id;
}

public void Modificar (PedidoProveedorEN pedidoProveedor)
{
        try
        {
                SessionInitializeTransaction ();
                PedidoProveedorEN pedidoProveedorEN = (PedidoProveedorEN)session.Load (typeof(PedidoProveedorEN), pedidoProveedor.Id);
                session.Update (pedidoProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
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
                PedidoProveedorEN pedidoProveedorEN = (PedidoProveedorEN)session.Load (typeof(PedidoProveedorEN), id);
                session.Delete (pedidoProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
