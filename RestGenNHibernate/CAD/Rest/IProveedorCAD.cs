
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IProveedorCAD
{
ProveedorEN ReadOIDDefault (int id
                            );

void ModifyDefault (ProveedorEN proveedor);

System.Collections.Generic.IList<ProveedorEN> ReadAllDefault (int first, int size);



int Nuevo (ProveedorEN proveedor);

void Modificar (ProveedorEN proveedor);


void Eliminar (int id
               );
}
}
