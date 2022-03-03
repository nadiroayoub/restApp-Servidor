
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface ITransacLineaCAD
{
TransacLineaEN ReadOIDDefault (int id
                               );

void ModifyDefault (TransacLineaEN transacLinea);

System.Collections.Generic.IList<TransacLineaEN> ReadAllDefault (int first, int size);



int Nuevo (TransacLineaEN transacLinea);

void Modificar (TransacLineaEN transacLinea);


void Eliminar (int id
               );
}
}
