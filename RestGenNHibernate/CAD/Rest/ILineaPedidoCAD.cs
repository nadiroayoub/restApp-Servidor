
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface ILineaPedidoCAD
{
LineaPedidoEN ReadOIDDefault (int id
                              );

void ModifyDefault (LineaPedidoEN lineaPedido);

System.Collections.Generic.IList<LineaPedidoEN> ReadAllDefault (int first, int size);



int NuevaLineaMenu (LineaPedidoEN lineaPedido);

void Modificar (LineaPedidoEN lineaPedido);


void Eliminar (int id
               );
}
}
