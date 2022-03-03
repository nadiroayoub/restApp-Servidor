
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
 * Clase Caja:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class CajaCAD : BasicCAD, ICajaCAD
{
public CajaCAD() : base ()
{
}

public CajaCAD(ISession sessionAux) : base (sessionAux)
{
}



public CajaEN ReadOIDDefault (int id
                              )
{
        CajaEN cajaEN = null;

        try
        {
                SessionInitializeTransaction ();
                cajaEN = (CajaEN)session.Get (typeof(CajaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in CajaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cajaEN;
}

public System.Collections.Generic.IList<CajaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CajaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CajaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CajaEN>();
                        else
                                result = session.CreateCriteria (typeof(CajaEN)).List<CajaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in CajaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CajaEN caja)
{
        try
        {
                SessionInitializeTransaction ();
                CajaEN cajaEN = (CajaEN)session.Load (typeof(CajaEN), caja.Id);

                cajaEN.Fecha = caja.Fecha;


                cajaEN.Fondo = caja.Fondo;


                cajaEN.Cash = caja.Cash;


                cajaEN.Desfase = caja.Desfase;




                session.Update (cajaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in CajaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (CajaEN caja)
{
        try
        {
                SessionInitializeTransaction ();
                if (caja.Negocio != null) {
                        // Argumento OID y no colección.
                        caja.Negocio = (RestGenNHibernate.EN.Rest.NegocioEN)session.Load (typeof(RestGenNHibernate.EN.Rest.NegocioEN), caja.Negocio.Id);

                        caja.Negocio.Caja
                        .Add (caja);
                }
                if (caja.Encargado != null) {
                        // Argumento OID y no colección.
                        caja.Encargado = (RestGenNHibernate.EN.Rest.EncargadoEN)session.Load (typeof(RestGenNHibernate.EN.Rest.EncargadoEN), caja.Encargado.Id);

                        caja.Encargado.Caja
                        .Add (caja);
                }

                session.Save (caja);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in CajaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return caja.Id;
}

public void Modificar (CajaEN caja)
{
        try
        {
                SessionInitializeTransaction ();
                CajaEN cajaEN = (CajaEN)session.Load (typeof(CajaEN), caja.Id);

                cajaEN.Fecha = caja.Fecha;


                cajaEN.Fondo = caja.Fondo;


                cajaEN.Cash = caja.Cash;


                cajaEN.Desfase = caja.Desfase;

                session.Update (cajaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in CajaCAD.", ex);
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
                CajaEN cajaEN = (CajaEN)session.Load (typeof(CajaEN), id);
                session.Delete (cajaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in CajaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.CajaEN> OperacionesCaja (Nullable<DateTime> p_fecha)
{
        System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.CajaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CajaEN self where FROM CajaEN caja where caja.fecha=p_fecha";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CajaENoperacionesCajaHQL");
                query.SetParameter ("p_fecha", p_fecha);

                result = query.List<RestGenNHibernate.EN.Rest.CajaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in CajaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
