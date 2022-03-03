
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IMesaCAD
{
MesaEN ReadOIDDefault (int id
                       );

void ModifyDefault (MesaEN mesa);

System.Collections.Generic.IList<MesaEN> ReadAllDefault (int first, int size);



int Nuevo (MesaEN mesa);

void Modificar (MesaEN mesa);


void Eliminar (int id
               );
}
}
