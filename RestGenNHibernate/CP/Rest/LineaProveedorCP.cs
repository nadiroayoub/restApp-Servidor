
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
public partial class LineaProveedorCP : BasicCP
{
public LineaProveedorCP() : base ()
{
}

public LineaProveedorCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}