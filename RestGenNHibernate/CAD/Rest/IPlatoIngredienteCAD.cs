
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IPlatoIngredienteCAD
{
PlatoIngredienteEN ReadOIDDefault (int id
                                   );

void ModifyDefault (PlatoIngredienteEN platoIngrediente);

System.Collections.Generic.IList<PlatoIngredienteEN> ReadAllDefault (int first, int size);



int Nuevo (PlatoIngredienteEN platoIngrediente);

void Modificar (PlatoIngredienteEN platoIngrediente);


void Eliminar (int id
               );
}
}
