
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface INegocioCAD
{
NegocioEN ReadOIDDefault (int id
                          );

void ModifyDefault (NegocioEN negocio);

System.Collections.Generic.IList<NegocioEN> ReadAllDefault (int first, int size);



int Nuevo (NegocioEN negocio);

void Modificar (NegocioEN negocio);


void Eliminar (int id
               );


System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.NegocioEN> DameMesaCliente (string p_dni);
}
}
