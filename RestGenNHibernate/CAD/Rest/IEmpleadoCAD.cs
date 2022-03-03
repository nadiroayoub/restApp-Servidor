
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IEmpleadoCAD
{
EmpleadoEN ReadOIDDefault (string dni
                           );

void ModifyDefault (EmpleadoEN empleado);

System.Collections.Generic.IList<EmpleadoEN> ReadAllDefault (int first, int size);



string Nuevo (EmpleadoEN empleado);

void Modificar (EmpleadoEN empleado);


void Eliminar (string dni
               );
}
}
