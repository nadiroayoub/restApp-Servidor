
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
 * Clase Dueño:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class DueñoCAD : BasicCAD, IDueñoCAD
{
public DueñoCAD() : base ()
{
}

public DueñoCAD(ISession sessionAux) : base (sessionAux)
{
}



public DueñoEN ReadOIDDefault (int dni
                               )
{
        DueñoEN dueñoEN = null;

        try
        {
                SessionInitializeTransaction ();
                dueñoEN = (DueñoEN)session.Get (typeof(DueñoEN), dni);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in DueñoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return dueñoEN;
}

public System.Collections.Generic.IList<DueñoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DueñoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DueñoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<DueñoEN>();
                        else
                                result = session.CreateCriteria (typeof(DueñoEN)).List<DueñoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in DueñoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DueñoEN dueño)
{
        try
        {
                SessionInitializeTransaction ();
                DueñoEN dueñoEN = (DueñoEN)session.Load (typeof(DueñoEN), dueño.Dni);


                dueñoEN.Nombre = dueño.Nombre;


                dueñoEN.Apellido = dueño.Apellido;


                dueñoEN.Telefono = dueño.Telefono;


                dueñoEN.Pass = dueño.Pass;

                session.Update (dueñoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in DueñoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (DueñoEN dueño)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (dueño);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in DueñoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return dueño.Dni;
}

public void Modificar (DueñoEN dueño)
{
        try
        {
                SessionInitializeTransaction ();
                DueñoEN dueñoEN = (DueñoEN)session.Load (typeof(DueñoEN), dueño.Dni);

                dueñoEN.Nombre = dueño.Nombre;


                dueñoEN.Apellido = dueño.Apellido;


                dueñoEN.Telefono = dueño.Telefono;


                dueñoEN.Pass = dueño.Pass;

                session.Update (dueñoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in DueñoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int dni
                      )
{
        try
        {
                SessionInitializeTransaction ();
                DueñoEN dueñoEN = (DueñoEN)session.Load (typeof(DueñoEN), dni);
                session.Delete (dueñoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in DueñoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
