
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IMovimientoCAD
{
MovimientoEN ReadOIDDefault (int id
                             );

void ModifyDefault (MovimientoEN movimiento);

System.Collections.Generic.IList<MovimientoEN> ReadAllDefault (int first, int size);



int Nuevo (MovimientoEN movimiento);

void Modificar (MovimientoEN movimiento);


void Eliminar (int id
               );
}
}
