
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IMenuCAD
{
MenuEN ReadOIDDefault (int id
                       );

void ModifyDefault (MenuEN menu);

System.Collections.Generic.IList<MenuEN> ReadAllDefault (int first, int size);



int Nuevo (MenuEN menu);

void Modificar (MenuEN menu);


void Eliminar (int id
               );
}
}
