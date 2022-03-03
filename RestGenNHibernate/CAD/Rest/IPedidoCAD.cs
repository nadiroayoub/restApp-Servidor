
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IPedidoCAD
{
PedidoEN ReadOIDDefault (int id
                         );

void ModifyDefault (PedidoEN pedido);

System.Collections.Generic.IList<PedidoEN> ReadAllDefault (int first, int size);



int Nuevo (PedidoEN pedido);

void Modificar (PedidoEN pedido);


void Eliminar (int id
               );


System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> DamePedidoPlato ();


System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PedidoEN> DamePedidoMenu ();
}
}
