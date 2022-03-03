
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
 * Clase Cliente:
 *
 */

namespace RestGenNHibernate.CAD.Rest
{
public partial class ClienteCAD : BasicCAD, IClienteCAD
{
public ClienteCAD() : base ()
{
}

public ClienteCAD(ISession sessionAux) : base (sessionAux)
{
}



public ClienteEN ReadOIDDefault (string dni
                                 )
{
        ClienteEN clienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Get (typeof(ClienteEN), dni);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEN;
}

public System.Collections.Generic.IList<ClienteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ClienteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ClienteEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ClienteEN>();
                        else
                                result = session.CreateCriteria (typeof(ClienteEN)).List<ClienteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), cliente.Dni);

                clienteEN.Nombre = cliente.Nombre;


                clienteEN.Apellidos = cliente.Apellidos;




                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string Nuevo (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();
                if (cliente.Factura != null) {
                        // Argumento OID y no colección.
                        cliente.Factura = (RestGenNHibernate.EN.Rest.FacturaEN)session.Load (typeof(RestGenNHibernate.EN.Rest.FacturaEN), cliente.Factura.Id);

                        cliente.Factura.Cliente
                        .Add (cliente);
                }
                if (cliente.Pago != null) {
                        // Argumento OID y no colección.
                        cliente.Pago = (RestGenNHibernate.EN.Rest.PagoEN)session.Load (typeof(RestGenNHibernate.EN.Rest.PagoEN), cliente.Pago.Id);

                        cliente.Pago.Cliente
                        .Add (cliente);
                }

                session.Save (cliente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cliente.Dni;
}

public void Modificar (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), cliente.Dni);

                clienteEN.Nombre = cliente.Nombre;


                clienteEN.Apellidos = cliente.Apellidos;

                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
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
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), dni);
                session.Delete (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is RestGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new RestGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
