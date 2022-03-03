
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IPagoCAD
{
PagoEN ReadOIDDefault (int id
                       );

void ModifyDefault (PagoEN pago);

System.Collections.Generic.IList<PagoEN> ReadAllDefault (int first, int size);



int Nuevo (PagoEN pago);

void Modificar (PagoEN pago);


void Eliminar (int id
               );


System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.PagoEN> DamePagos ();
}
}
