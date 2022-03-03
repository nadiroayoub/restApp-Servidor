
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
 * Clase Empleado:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class EmpleadoCAD : BasicCAD, IEmpleadoCAD
{
public EmpleadoCAD() : base ()
{
}

public EmpleadoCAD(ISession sessionAux) : base (sessionAux)
{
}



public EmpleadoEN ReadOIDDefault (string dni
                                  )
{
        EmpleadoEN empleadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                empleadoEN = (EmpleadoEN)session.Get (typeof(EmpleadoEN), dni);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return empleadoEN;
}

public System.Collections.Generic.IList<EmpleadoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EmpleadoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EmpleadoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EmpleadoEN>();
                        else
                                result = session.CreateCriteria (typeof(EmpleadoEN)).List<EmpleadoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EmpleadoEN empleado)
{
        try
        {
                SessionInitializeTransaction ();
                EmpleadoEN empleadoEN = (EmpleadoEN)session.Load (typeof(EmpleadoEN), empleado.Dni);

                empleadoEN.Nombre = empleado.Nombre;


                empleadoEN.Apellidos = empleado.Apellidos;


                empleadoEN.Telefono = empleado.Telefono;




                empleadoEN.Pass = empleado.Pass;

                session.Update (empleadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string Nuevo (EmpleadoEN empleado)
{
        try
        {
                SessionInitializeTransaction ();
                if (empleado.Negocio != null) {
                        // Argumento OID y no colección.
                        empleado.Negocio = (RestGenNHibernate.EN.Rest.NegocioEN)session.Load (typeof(RestGenNHibernate.EN.Rest.NegocioEN), empleado.Negocio.Id);

                        empleado.Negocio.Empleado
                        .Add (empleado);
                }

                session.Save (empleado);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return empleado.Dni;
}

public void Modificar (EmpleadoEN empleado)
{
        try
        {
                SessionInitializeTransaction ();
                EmpleadoEN empleadoEN = (EmpleadoEN)session.Load (typeof(EmpleadoEN), empleado.Dni);

                empleadoEN.Nombre = empleado.Nombre;


                empleadoEN.Apellidos = empleado.Apellidos;


                empleadoEN.Telefono = empleado.Telefono;


                empleadoEN.Pass = empleado.Pass;

                session.Update (empleadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (string dni
                      )
{
        try
        {
                SessionInitializeTransaction ();
                EmpleadoEN empleadoEN = (EmpleadoEN)session.Load (typeof(EmpleadoEN), dni);
                session.Delete (empleadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EmpleadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
