
using System;
// Definición clase EncargadoEN
namespace RestGenNHibernate.EN.Rest
{
public partial class EncargadoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo rol
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> rol;



/**
 *	Atributo caja
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.CajaEN> caja;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> Rol {
        get { return rol; } set { rol = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.CajaEN> Caja {
        get { return caja; } set { caja = value;  }
}





public EncargadoEN()
{
        rol = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.RolEN>();
        caja = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.CajaEN>();
}



public EncargadoEN(int id, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> rol, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.CajaEN> caja
                   )
{
        this.init (Id, rol, caja);
}


public EncargadoEN(EncargadoEN encargado)
{
        this.init (Id, encargado.Rol, encargado.Caja);
}

private void init (int id
                   , System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> rol, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.CajaEN> caja)
{
        this.Id = id;


        this.Rol = rol;

        this.Caja = caja;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EncargadoEN t = obj as EncargadoEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
