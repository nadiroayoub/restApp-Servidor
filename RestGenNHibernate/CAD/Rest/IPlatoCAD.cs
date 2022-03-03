
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IPlatoCAD
{
PlatoEN ReadOIDDefault (int id
                        );

void ModifyDefault (PlatoEN plato);

System.Collections.Generic.IList<PlatoEN> ReadAllDefault (int first, int size);



int Nuevo (PlatoEN plato);

void Modificar (PlatoEN plato);


void Eliminar (int id
               );
}
}
