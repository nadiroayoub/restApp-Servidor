
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IBebidaCAD
{
BebidaEN ReadOIDDefault (int id
                         );

void ModifyDefault (BebidaEN bebida);

System.Collections.Generic.IList<BebidaEN> ReadAllDefault (int first, int size);



int Nuevo (BebidaEN bebida);

void Modificar (BebidaEN bebida);


void Eliminar (int id
               );
}
}
