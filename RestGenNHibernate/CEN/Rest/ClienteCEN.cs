

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using RestGenNHibernate.Exceptions;

using RestGenNHibernate.EN.Rest;
using RestGenNHibernate.CAD.Rest;


namespace RestGenNHibernate.CEN.Rest
{
/*
 *      Definition of the class ClienteCEN
 *
 */
public partial class ClienteCEN
{
private IClienteCAD _IClienteCAD;

public ClienteCEN()
{
        this._IClienteCAD = new ClienteCAD ();
}

public ClienteCEN(IClienteCAD _IClienteCAD)
{
        this._IClienteCAD = _IClienteCAD;
}

public IClienteCAD get_IClienteCAD ()
{
        return this._IClienteCAD;
}

public string Nuevo (string p_dni, string p_nombre, string p_apellidos, int p_factura, int p_pago)
{
        ClienteEN clienteEN = null;
        string oid;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Dni = p_dni;

        clienteEN.Nombre = p_nombre;

        clienteEN.Apellidos = p_apellidos;


        if (p_factura != -1) {
                // El argumento p_factura -> Property factura es oid = false
                // Lista de oids dni
                clienteEN.Factura = new RestGenNHibernate.EN.Rest.FacturaEN ();
                clienteEN.Factura.Id = p_factura;
        }


        if (p_pago != -1) {
                // El argumento p_pago -> Property pago es oid = false
                // Lista de oids dni
                clienteEN.Pago = new RestGenNHibernate.EN.Rest.PagoEN ();
                clienteEN.Pago.Id = p_pago;
        }

        //Call to ClienteCAD

        oid = _IClienteCAD.Nuevo (clienteEN);
        return oid;
}

public void Modificar (string p_Cliente_OID, string p_nombre, string p_apellidos)
{
        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Dni = p_Cliente_OID;
        clienteEN.Nombre = p_nombre;
        clienteEN.Apellidos = p_apellidos;
        //Call to ClienteCAD

        _IClienteCAD.Modificar (clienteEN);
}

public void Eliminar (string dni
                      )
{
        _IClienteCAD.Eliminar (dni);
}
}
}
