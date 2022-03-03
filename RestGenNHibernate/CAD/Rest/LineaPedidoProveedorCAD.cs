
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
 * Clase LineaPedidoProveedor:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class LineaPedidoProveedorCAD : BasicCAD, ILineaPedidoProveedorCAD
{
public LineaPedidoProveedorCAD() : base ()
{
}

public LineaPedidoProveedorCAD(ISession sessionAux) : base (sessionAux)
{
}



public LineaPedidoProveedorEN ReadOIDDefault (int id
                                              )
{
        LineaPedidoProveedorEN lineaPedidoProveedorEN = null;

        try
        {
                SessionInitializeTransaction ();
                lineaPedidoProveedorEN = (LineaPedidoProveedorEN)session.Get (typeof(LineaPedidoProveedorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaPedidoProveedorEN;
}

public System.Collections.Generic.IList<LineaPedidoProveedorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<LineaPedidoProveedorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(LineaPedidoProveedorEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<LineaPedidoProveedorEN>();
                        else
                                result = session.CreateCriteria (typeof(LineaPedidoProveedorEN)).List<LineaPedidoProveedorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoProveedorCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (LineaPedidoProveedorEN lineaPedidoProveedor)
{
        try
        {
                SessionInitializeTransaction ();
                LineaPedidoProveedorEN lineaPedidoProveedorEN = (LineaPedidoProveedorEN)session.Load (typeof(LineaPedidoProveedorEN), lineaPedidoProveedor.Id);

                lineaPedidoProveedorEN.Cantidad = lineaPedidoProveedor.Cantidad;




                session.Update (lineaPedidoProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int NuevaLineaServicio (LineaPedidoProveedorEN lineaPedidoProveedor)
{
        try
        {
                SessionInitializeTransaction ();
                if (lineaPedidoProveedor.PedidoProveedor != null) {
                        // Argumento OID y no colección.
                        lineaPedidoProveedor.PedidoProveedor = (RestGenNHibernate.EN.Rest.PedidoProveedorEN)session.Load (typeof(RestGenNHibernate.EN.Rest.PedidoProveedorEN), lineaPedidoProveedor.PedidoProveedor.Id);

                        lineaPedidoProveedor.PedidoProveedor.LineaProveedor
                        .Add (lineaPedidoProveedor);
                }

                session.Save (lineaPedidoProveedor);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaPedidoProveedor.Id;
}

public void Modificar (LineaPedidoProveedorEN lineaPedidoProveedor)
{
        try
        {
                SessionInitializeTransaction ();
                LineaPedidoProveedorEN lineaPedidoProveedorEN = (LineaPedidoProveedorEN)session.Load (typeof(LineaPedidoProveedorEN), lineaPedidoProveedor.Id);

                lineaPedidoProveedorEN.Cantidad = lineaPedidoProveedor.Cantidad;

                session.Update (lineaPedidoProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoProveedorCAD.", ex);
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
                LineaPedidoProveedorEN lineaPedidoProveedorEN = (LineaPedidoProveedorEN)session.Load (typeof(LineaPedidoProveedorEN), id);
                session.Delete (lineaPedidoProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
