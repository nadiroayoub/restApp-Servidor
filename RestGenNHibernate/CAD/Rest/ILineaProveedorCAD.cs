
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface ILineaProveedorCAD
{
LineaProveedorEN ReadOIDDefault (int id
                                 );

void ModifyDefault (LineaProveedorEN lineaProveedor);

System.Collections.Generic.IList<LineaProveedorEN> ReadAllDefault (int first, int size);



int Nuevo (LineaProveedorEN lineaProveedor);

void Modificar (LineaProveedorEN lineaProveedor);


void Eliminar (int id
               );
}
}
