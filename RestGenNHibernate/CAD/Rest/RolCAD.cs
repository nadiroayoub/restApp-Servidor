
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
 * Clase Rol:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class RolCAD : BasicCAD, IRolCAD
{
public RolCAD() : base ()
{
}

public RolCAD(ISession sessionAux) : base (sessionAux)
{
}



public RolEN ReadOIDDefault (int id
                             )
{
        RolEN rolEN = null;

        try
        {
                SessionInitializeTransaction ();
                rolEN = (RolEN)session.Get (typeof(RolEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in RolCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return rolEN;
}

public System.Collections.Generic.IList<RolEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RolEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RolEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RolEN>();
                        else
                                result = session.CreateCriteria (typeof(RolEN)).List<RolEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in RolCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RolEN rol)
{
        try
        {
                SessionInitializeTransaction ();
                RolEN rolEN = (RolEN)session.Load (typeof(RolEN), rol.Id);





                session.Update (rolEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in RolCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int NuevoCajero (RolEN rol)
{
        try
        {
                SessionInitializeTransaction ();
                if (rol.Usuario != null) {
                        // Argumento OID y no colección.
                        rol.Usuario = (RestGenNHibernate.EN.Rest.EmpleadoEN)session.Load (typeof(RestGenNHibernate.EN.Rest.EmpleadoEN), rol.Usuario.Dni);

                        rol.Usuario.Rol
                        .Add (rol);
                }

                session.Save (rol);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in RolCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return rol.Id;
}

public void Modificar (RolEN rol)
{
        try
        {
                SessionInitializeTransaction ();
                RolEN rolEN = (RolEN)session.Load (typeof(RolEN), rol.Id);
                session.Update (rolEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in RolCAD.", ex);
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
                RolEN rolEN = (RolEN)session.Load (typeof(RolEN), id);
                session.Delete (rolEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in RolCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public int NuevoCobcinero (RolEN rol)
{
        try
        {
                SessionInitializeTransaction ();
                if (rol.Usuario != null) {
                        // Argumento OID y no colección.
                        rol.Usuario = (RestGenNHibernate.EN.Rest.EmpleadoEN)session.Load (typeof(RestGenNHibernate.EN.Rest.EmpleadoEN), rol.Usuario.Dni);

                        rol.Usuario.Rol
                        .Add (rol);
                }

                session.Save (rol);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in RolCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return rol.Id;
}
}
}
