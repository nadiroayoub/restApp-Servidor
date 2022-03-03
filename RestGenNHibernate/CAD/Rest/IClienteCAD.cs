
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (string dni
                          );

void ModifyDefault (ClienteEN cliente);

System.Collections.Generic.IList<ClienteEN> ReadAllDefault (int first, int size);



string Nuevo (ClienteEN cliente);

void Modificar (ClienteEN cliente);


void Eliminar (string dni
               );
}
}
