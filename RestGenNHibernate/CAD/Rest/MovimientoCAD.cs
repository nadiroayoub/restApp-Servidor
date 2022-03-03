
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
 * Clase Movimiento:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class MovimientoCAD : BasicCAD, IMovimientoCAD
{
public MovimientoCAD() : base ()
{
}

public MovimientoCAD(ISession sessionAux) : base (sessionAux)
{
}



public MovimientoEN ReadOIDDefault (int id
                                    )
{
        MovimientoEN movimientoEN = null;

        try
        {
                SessionInitializeTransaction ();
                movimientoEN = (MovimientoEN)session.Get (typeof(MovimientoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in MovimientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return movimientoEN;
}

public System.Collections.Generic.IList<MovimientoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MovimientoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MovimientoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MovimientoEN>();
                        else
                                result = session.CreateCriteria (typeof(MovimientoEN)).List<MovimientoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in MovimientoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MovimientoEN movimiento)
{
        try
        {
                SessionInitializeTransaction ();
                MovimientoEN movimientoEN = (MovimientoEN)session.Load (typeof(MovimientoEN), movimiento.Id);

                movimientoEN.Descripcion = movimiento.Descripcion;


                movimientoEN.Fecha = movimiento.Fecha;


                movimientoEN.Cantidad = movimiento.Cantidad;


                movimientoEN.Unidad = movimiento.Unidad;


                session.Update (movimientoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in MovimientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (MovimientoEN movimiento)
{
        try
        {
                SessionInitializeTransaction ();
                if (movimiento.Negocio != null) {
                        // Argumento OID y no colección.
                        movimiento.Negocio = (RestGenNHibernate.EN.Rest.NegocioEN)session.Load (typeof(RestGenNHibernate.EN.Rest.NegocioEN), movimiento.Negocio.Id);

                        movimiento.Negocio.Movimiento
                        .Add (movimiento);
                }

                session.Save (movimiento);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in MovimientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return movimiento.Id;
}

public void Modificar (MovimientoEN movimiento)
{
        try
        {
                SessionInitializeTransaction ();
                MovimientoEN movimientoEN = (MovimientoEN)session.Load (typeof(MovimientoEN), movimiento.Id);

                movimientoEN.Descripcion = movimiento.Descripcion;


                movimientoEN.Fecha = movimiento.Fecha;


                movimientoEN.Cantidad = movimiento.Cantidad;


                movimientoEN.Unidad = movimiento.Unidad;

                session.Update (movimientoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in MovimientoCAD.", ex);
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
                MovimientoEN movimientoEN = (MovimientoEN)session.Load (typeof(MovimientoEN), id);
                session.Delete (movimientoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in MovimientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
