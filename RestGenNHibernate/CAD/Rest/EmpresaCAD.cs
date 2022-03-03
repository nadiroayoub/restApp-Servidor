
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
 * Clase Empresa:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class EmpresaCAD : BasicCAD, IEmpresaCAD
{
public EmpresaCAD() : base ()
{
}

public EmpresaCAD(ISession sessionAux) : base (sessionAux)
{
}



public EmpresaEN ReadOIDDefault (int id
                                 )
{
        EmpresaEN empresaEN = null;

        try
        {
                SessionInitializeTransaction ();
                empresaEN = (EmpresaEN)session.Get (typeof(EmpresaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EmpresaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return empresaEN;
}

public System.Collections.Generic.IList<EmpresaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EmpresaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EmpresaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EmpresaEN>();
                        else
                                result = session.CreateCriteria (typeof(EmpresaEN)).List<EmpresaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EmpresaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EmpresaEN empresa)
{
        try
        {
                SessionInitializeTransaction ();
                EmpresaEN empresaEN = (EmpresaEN)session.Load (typeof(EmpresaEN), empresa.Id);

                empresaEN.Nombre = empresa.Nombre;


                empresaEN.Direccion = empresa.Direccion;



                session.Update (empresaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EmpresaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (EmpresaEN empresa)
{
        try
        {
                SessionInitializeTransaction ();
                if (empresa.Negocio != null) {
                        for (int i = 0; i < empresa.Negocio.Count; i++) {
                                empresa.Negocio [i] = (RestGenNHibernate.EN.Rest.NegocioEN)session.Load (typeof(RestGenNHibernate.EN.Rest.NegocioEN), empresa.Negocio [i].Id);
                                empresa.Negocio [i].Empresa = empresa;
                        }
                }

                session.Save (empresa);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EmpresaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return empresa.Id;
}

public void Modificar (EmpresaEN empresa)
{
        try
        {
                SessionInitializeTransaction ();
                EmpresaEN empresaEN = (EmpresaEN)session.Load (typeof(EmpresaEN), empresa.Id);

                empresaEN.Nombre = empresa.Nombre;


                empresaEN.Direccion = empresa.Direccion;

                session.Update (empresaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EmpresaCAD.", ex);
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
                EmpresaEN empresaEN = (EmpresaEN)session.Load (typeof(EmpresaEN), id);
                session.Delete (empresaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EmpresaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.EmpresaEN> DameNegocio ()
{
        System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.EmpresaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EmpresaEN self where FROM EmpresaEN empresa select empresa.Negocio";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EmpresaENDameNegocioHQL");

                result = query.List<RestGenNHibernate.EN.Rest.EmpresaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in EmpresaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
