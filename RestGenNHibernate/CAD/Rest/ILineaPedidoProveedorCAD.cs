
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface ILineaPedidoProveedorCAD
{
LineaPedidoProveedorEN ReadOIDDefault (int id
                                       );

void ModifyDefault (LineaPedidoProveedorEN lineaPedidoProveedor);

System.Collections.Generic.IList<LineaPedidoProveedorEN> ReadAllDefault (int first, int size);



int NuevaLineaServicio (LineaPedidoProveedorEN lineaPedidoProveedor);

void Modificar (LineaPedidoProveedorEN lineaPedidoProveedor);


void Eliminar (int id
               );
}
}
