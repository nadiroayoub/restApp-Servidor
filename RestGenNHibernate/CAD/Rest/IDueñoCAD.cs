
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IDueñoCAD
{
DueñoEN ReadOIDDefault (int dni
                        );

void ModifyDefault (DueñoEN dueño);

System.Collections.Generic.IList<DueñoEN> ReadAllDefault (int first, int size);



int Nuevo (DueñoEN dueño);

void Modificar (DueñoEN dueño);


void Eliminar (int dni
               );
}
}
