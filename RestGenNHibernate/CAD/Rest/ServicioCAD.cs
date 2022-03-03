
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
 * Clase Servicio:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class ServicioCAD : BasicCAD, IServicioCAD
{
public ServicioCAD() : base ()
{
}

public ServicioCAD(ISession sessionAux) : base (sessionAux)
{
}



public ServicioEN ReadOIDDefault (int id
                                  )
{
        ServicioEN servicioEN = null;

        try
        {
                SessionInitializeTransaction ();
                servicioEN = (ServicioEN)session.Get (typeof(ServicioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ServicioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return servicioEN;
}

public System.Collections.Generic.IList<ServicioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ServicioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ServicioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ServicioEN>();
                        else
                                result = session.CreateCriteria (typeof(ServicioEN)).List<ServicioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ServicioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ServicioEN servicio)
{
        try
        {
                SessionInitializeTransaction ();
                ServicioEN servicioEN = (ServicioEN)session.Load (typeof(ServicioEN), servicio.Id);

                servicioEN.Tipo = servicio.Tipo;


                servicioEN.Fecha = servicio.Fecha;



                servicioEN.Nombre = servicio.Nombre;


                servicioEN.Monto = servicio.Monto;


                session.Update (servicioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ServicioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (ServicioEN servicio)
{
        try
        {
                SessionInitializeTransaction ();
                if (servicio.Negocio != null) {
                        // Argumento OID y no colección.
                        servicio.Negocio = (RestGenNHibernate.EN.Rest.NegocioEN)session.Load (typeof(RestGenNHibernate.EN.Rest.NegocioEN), servicio.Negocio.Id);

                        servicio.Negocio.Servicios
                        .Add (servicio);
                }

                session.Save (servicio);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ServicioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return servicio.Id;
}

public void Modificar (ServicioEN servicio)
{
        try
        {
                SessionInitializeTransaction ();
                ServicioEN servicioEN = (ServicioEN)session.Load (typeof(ServicioEN), servicio.Id);

                servicioEN.Tipo = servicio.Tipo;


                servicioEN.Fecha = servicio.Fecha;


                servicioEN.Nombre = servicio.Nombre;


                servicioEN.Monto = servicio.Monto;

                session.Update (servicioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ServicioCAD.", ex);
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
                ServicioEN servicioEN = (ServicioEN)session.Load (typeof(ServicioEN), id);
                session.Delete (servicioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ServicioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
