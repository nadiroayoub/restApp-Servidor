
using System;
// Definición clase CajeroEN
namespace RestGenNHibernate.EN.Rest
{
public partial class CajeroEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo rol
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> rol;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> Rol {
        get { return rol; } set { rol = value;  }
}





public CajeroEN()
{
        rol = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.RolEN>();
}



public CajeroEN(int id, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> rol
                )
{
        this.init (Id, rol);
}


public CajeroEN(CajeroEN cajero)
{
        this.init (Id, cajero.Rol);
}

private void init (int id
                   , System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> rol)
{
        this.Id = id;


        this.Rol = rol;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CajeroEN t = obj as CajeroEN;
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
