
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface ICajaCAD
{
CajaEN ReadOIDDefault (int id
                       );

void ModifyDefault (CajaEN caja);

System.Collections.Generic.IList<CajaEN> ReadAllDefault (int first, int size);



int Nuevo (CajaEN caja);

void Modificar (CajaEN caja);


void Eliminar (int id
               );




System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.CajaEN> OperacionesCaja (Nullable<DateTime> p_fecha);
}
}
