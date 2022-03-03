
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IFacturaCAD
{
FacturaEN ReadOIDDefault (int id
                          );

void ModifyDefault (FacturaEN factura);

System.Collections.Generic.IList<FacturaEN> ReadAllDefault (int first, int size);



int Nuevo (FacturaEN factura);

void Modificar (FacturaEN factura);


void Eliminar (int id
               );


System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.FacturaEN> DameFacturaPedidoPago (int p_iFfactura);


System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.FacturaEN> DameFacturaCliente (int p_idFactura);
}
}
