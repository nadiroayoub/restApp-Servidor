
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using RestGenNHibernate.Exceptions;
using RestGenNHibernate.EN.Rest;
using RestGenNHibernate.CAD.Rest;
using RestGenNHibernate.CEN.Rest;



namespace RestGenNHibernate.CP.Rest
{
public partial class EmpleadoCP : BasicCP
{
public EmpleadoCP() : base ()
{
}

public EmpleadoCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
