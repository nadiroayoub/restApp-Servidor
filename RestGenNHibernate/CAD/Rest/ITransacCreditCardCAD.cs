
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface ITransacCreditCardCAD
{
TransacCreditCardEN ReadOIDDefault (int id
                                    );

void ModifyDefault (TransacCreditCardEN transacCreditCard);

System.Collections.Generic.IList<TransacCreditCardEN> ReadAllDefault (int first, int size);



int Nuevo (TransacCreditCardEN transacCreditCard);

void Modificar (TransacCreditCardEN transacCreditCard);


void Eliminar (int id
               );
}
}
