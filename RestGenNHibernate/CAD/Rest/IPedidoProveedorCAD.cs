
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IPedidoProveedorCAD
{
PedidoProveedorEN ReadOIDDefault (int id
                                  );

void ModifyDefault (PedidoProveedorEN pedidoProveedor);

System.Collections.Generic.IList<PedidoProveedorEN> ReadAllDefault (int first, int size);



int Nuevo (PedidoProveedorEN pedidoProveedor);

void Modificar (PedidoProveedorEN pedidoProveedor);


void Eliminar (int id
               );
}
}
