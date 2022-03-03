
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IRolCAD
{
RolEN ReadOIDDefault (int id
                      );

void ModifyDefault (RolEN rol);

System.Collections.Generic.IList<RolEN> ReadAllDefault (int first, int size);



int NuevoCajero (RolEN rol);

void Modificar (RolEN rol);


void Eliminar (int id
               );



int NuevoCobcinero (RolEN rol);
}
}
