
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IServicioCAD
{
ServicioEN ReadOIDDefault (int id
                           );

void ModifyDefault (ServicioEN servicio);

System.Collections.Generic.IList<ServicioEN> ReadAllDefault (int first, int size);



int Nuevo (ServicioEN servicio);

void Modificar (ServicioEN servicio);


void Eliminar (int id
               );
}
}
