
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
 * Clase Pedido:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class PedidoCAD : BasicCAD, IPedidoCAD
{
public PedidoCAD() : base ()
{
}

public PedidoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PedidoEN ReadOIDDefault (int id
                                )
{
        PedidoEN pedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Get (typeof(PedidoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoEN;
}

public System.Collections.Generic.IList<PedidoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PedidoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PedidoEN>();
                        else
                                result = session.CreateCriteria (typeof(PedidoEN)).List<PedidoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                PedidoEN pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), pedido.Id);

                pedidoEN.EstadoPedido = pedido.EstadoPedido;







                pedidoEN.Fecha = pedido.Fecha;


                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                if (pedido.Camarero != null) {
                        // Argumento OID y no colección.
                        pedido.Camarero = (RestGenNHibernate.EN.Rest.CamareroEN)session.Load (typeof(RestGenNHibernate.EN.Rest.CamareroEN), pedido.Camarero.Id);

                        pedido.Camarero.Pedido
                        .Add (pedido);
                }
                if (pedido.Mesa != null) {
                        // Argumento OID y no colección.
                        pedido.Mesa = (RestGenNHibernate.EN.Rest.MesaEN)session.Load (typeof(RestGenNHibernate.EN.Rest.MesaEN), pedido.Mesa.Id);

                        pedido.Mesa.Pedido
                        .Add (pedido);
                }
                if (pedido.Caja != null) {
                        // Argumento OID y no colección.
                        pedido.Caja = (RestGenNHibernate.EN.Rest.CajaEN)session.Load (typeof(RestGenNHibernate.EN.Rest.CajaEN), pedido.Caja.Id);

                        pedido.Caja.Pedido
                        .Add (pedido);
                }

                session.Save (pedido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedido.Id;
}

public void Modificar (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                PedidoEN pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), pedido.Id);

                pedidoEN.EstadoPedido = pedido.EstadoPedido;


                pedidoEN.Fecha = pedido.Fecha;

                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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
                PedidoEN pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), id);
                session.Delete (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> DamePedidoPlato ()
{
        System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PedidoEN self where select ped FROM PedidoEN as ped inner join ped.LineaPedido as lin where lin.Plato.Id =: p_idPlato";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PedidoENDamePedidoPlatoHQL");

                result = query.List<RestGenNHibernate.EN.Rest.PedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> DamePedidoMenu ()
{
        System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PedidoEN self where selec ped FROM PedidoEN as ped inner join ped.LineaPedido as lin where lin.Menu.Id =: p_idMenu";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PedidoENDamePedidoMenuHQL");

                result = query.List<RestGenNHibernate.EN.Rest.PedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
