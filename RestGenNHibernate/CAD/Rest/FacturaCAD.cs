
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
 * Clase Factura:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class FacturaCAD : BasicCAD, IFacturaCAD
{
public FacturaCAD() : base ()
{
}

public FacturaCAD(ISession sessionAux) : base (sessionAux)
{
}



public FacturaEN ReadOIDDefault (int id
                                 )
{
        FacturaEN facturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                facturaEN = (FacturaEN)session.Get (typeof(FacturaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(FacturaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<FacturaEN>();
                        else
                                result = session.CreateCriteria (typeof(FacturaEN)).List<FacturaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (FacturaEN factura)
{
        try
        {
                SessionInitializeTransaction ();
                FacturaEN facturaEN = (FacturaEN)session.Load (typeof(FacturaEN), factura.Id);

                facturaEN.Numero = factura.Numero;


                facturaEN.Fecha = factura.Fecha;


                facturaEN.Precio = factura.Precio;


                facturaEN.Descripcion = factura.Descripcion;




                facturaEN.Nif_nie = factura.Nif_nie;

                session.Update (facturaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (FacturaEN factura)
{
        try
        {
                SessionInitializeTransaction ();
                if (factura.Pedido != null) {
                        // Argumento OID y no colección.
                        factura.Pedido = (RestGenNHibernate.EN.Rest.PedidoEN)session.Load (typeof(RestGenNHibernate.EN.Rest.PedidoEN), factura.Pedido.Id);

                        factura.Pedido.Factura
                                = factura;
                }

                session.Save (factura);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return factura.Id;
}

public void Modificar (FacturaEN factura)
{
        try
        {
                SessionInitializeTransaction ();
                FacturaEN facturaEN = (FacturaEN)session.Load (typeof(FacturaEN), factura.Id);

                facturaEN.Numero = factura.Numero;


                facturaEN.Fecha = factura.Fecha;


                facturaEN.Precio = factura.Precio;


                facturaEN.Descripcion = factura.Descripcion;


                facturaEN.Nif_nie = factura.Nif_nie;

                session.Update (facturaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
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
                FacturaEN facturaEN = (FacturaEN)session.Load (typeof(FacturaEN), id);
                session.Delete (facturaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.FacturaEN> DameFacturaPedidoPago (int p_iFfactura)
{
        System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.FacturaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM FacturaEN self where select fact FROM FacturaEN as fact inner join fact.Pedido as ped where ped.Pago.Id =: p_idFactura";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("FacturaENDameFacturaPedidoPagoHQL");
                query.SetParameter ("p_iFfactura", p_iFfactura);

                result = query.List<RestGenNHibernate.EN.Rest.FacturaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.FacturaEN> DameFacturaCliente (int p_idFactura)
{
        System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.FacturaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM FacturaEN self where select fact FROM FacturaEN as fact inner join fact.Pedido as ped where ped.Pago.Id =: p_idFactura";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("FacturaENDameFacturaClienteHQL");
                query.SetParameter ("p_idFactura", p_idFactura);

                result = query.List<RestGenNHibernate.EN.Rest.FacturaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
