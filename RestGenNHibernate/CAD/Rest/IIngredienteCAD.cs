
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface IIngredienteCAD
{
IngredienteEN ReadOIDDefault (int id
                              );

void ModifyDefault (IngredienteEN ingrediente);

System.Collections.Generic.IList<IngredienteEN> ReadAllDefault (int first, int size);



int Nuevo (IngredienteEN ingrediente);

void Modificar (IngredienteEN ingrediente);


void Eliminar (int id
               );




System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.IngredienteEN> DameIngredienteProveedor ();


System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.IngredienteEN> DameIngredientePlato (int p_idePlato);
}
}
