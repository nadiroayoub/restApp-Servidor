
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IComidaCAD
{
ComidaEN ReadOIDDefault (int id
                         );

void ModifyDefault (ComidaEN comida);

System.Collections.Generic.IList<ComidaEN> ReadAllDefault (int first, int size);



int Nuevo (ComidaEN comida);

void Modificar (ComidaEN comida);


void Eliminar (int id
               );
}
}
