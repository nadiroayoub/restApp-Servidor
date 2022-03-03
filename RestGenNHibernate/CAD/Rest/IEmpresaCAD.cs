
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IEmpresaCAD
{
EmpresaEN ReadOIDDefault (int id
                          );

void ModifyDefault (EmpresaEN empresa);

System.Collections.Generic.IList<EmpresaEN> ReadAllDefault (int first, int size);



int Nuevo (EmpresaEN empresa);

void Modificar (EmpresaEN empresa);


void Eliminar (int id
               );


System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.EmpresaEN> DameNegocio ();
}
}
