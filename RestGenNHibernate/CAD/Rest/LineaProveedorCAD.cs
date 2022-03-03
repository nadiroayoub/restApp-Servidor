
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
 * Clase LineaProveedor:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class LineaProveedorCAD : BasicCAD, ILineaProveedorCAD
{
public LineaProveedorCAD() : base ()
{
}

public LineaProveedorCAD(ISession sessionAux) : base (sessionAux)
{
}



public LineaProveedorEN ReadOIDDefault (int id
                                        )
{
        LineaProveedorEN lineaProveedorEN = null;

        try
        {
                SessionInitializeTransaction ();
                lineaProveedorEN = (LineaProveedorEN)session.Get (typeof(LineaProveedorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in LineaProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaProveedorEN;
}

public System.Collections.Generic.IList<LineaProveedorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<LineaProveedorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(LineaProveedorEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<LineaProveedorEN>();
                        else
                                result = session.CreateCriteria (typeof(LineaProveedorEN)).List<LineaProveedorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in LineaProveedorCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (LineaProveedorEN lineaProveedor)
{
        try
        {
                SessionInitializeTransaction ();
                LineaProveedorEN lineaProveedorEN = (LineaProveedorEN)session.Load (typeof(LineaProveedorEN), lineaProveedor.Id);

                lineaProveedorEN.Cantidad = lineaProveedor.Cantidad;




                session.Update (lineaProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in LineaProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (LineaProveedorEN lineaProveedor)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (lineaProveedor);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in LineaProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaProveedor.Id;
}

public void Modificar (LineaProveedorEN lineaProveedor)
{
        try
        {
                SessionInitializeTransaction ();
                LineaProveedorEN lineaProveedorEN = (LineaProveedorEN)session.Load (typeof(LineaProveedorEN), lineaProveedor.Id);

                lineaProveedorEN.Cantidad = lineaProveedor.Cantidad;

                session.Update (lineaProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in LineaProveedorCAD.", ex);
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
                LineaProveedorEN lineaProveedorEN = (LineaProveedorEN)session.Load (typeof(LineaProveedorEN), id);
                session.Delete (lineaProveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in LineaProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
