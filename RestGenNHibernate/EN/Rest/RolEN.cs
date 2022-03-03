
using System;
// Definición clase RolEN
namespace RestGenNHibernate.EN.Rest
{
public partial class RolEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo usuario
 */
private RestGenNHibernate.EN.Rest.EmpleadoEN usuario;



/**
 *	Atributo cajero
 */
private RestGenNHibernate.EN.Rest.CajeroEN cajero;



/**
 *	Atributo cocinero
 */
private RestGenNHibernate.EN.Rest.CocineroEN cocinero;



/**
 *	Atributo encargado
 */
private RestGenNHibernate.EN.Rest.EncargadoEN encargado;



/**
 *	Atributo camarero
 */
private RestGenNHibernate.EN.Rest.CamareroEN camarero;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual RestGenNHibernate.EN.Rest.EmpleadoEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual RestGenNHibernate.EN.Rest.CajeroEN Cajero {
        get { return cajero; } set { cajero = value;  }
}



public virtual RestGenNHibernate.EN.Rest.CocineroEN Cocinero {
        get { return cocinero; } set { cocinero = value;  }
}



public virtual RestGenNHibernate.EN.Rest.EncargadoEN Encargado {
        get { return encargado; } set { encargado = value;  }
}



public virtual RestGenNHibernate.EN.Rest.CamareroEN Camarero {
        get { return camarero; } set { camarero = value;  }
}





public RolEN()
{
}



public RolEN(int id, RestGenNHibernate.EN.Rest.EmpleadoEN usuario, RestGenNHibernate.EN.Rest.CajeroEN cajero, RestGenNHibernate.EN.Rest.CocineroEN cocinero, RestGenNHibernate.EN.Rest.EncargadoEN encargado, RestGenNHibernate.EN.Rest.CamareroEN camarero
             )
{
        this.init (Id, usuario, cajero, cocinero, encargado, camarero);
}


public RolEN(RolEN rol)
{
        this.init (Id, rol.Usuario, rol.Cajero, rol.Cocinero, rol.Encargado, rol.Camarero);
}

private void init (int id
                   , RestGenNHibernate.EN.Rest.EmpleadoEN usuario, RestGenNHibernate.EN.Rest.CajeroEN cajero, RestGenNHibernate.EN.Rest.CocineroEN cocinero, RestGenNHibernate.EN.Rest.EncargadoEN encargado, RestGenNHibernate.EN.Rest.CamareroEN camarero)
{
        this.Id = id;


        this.Usuario = usuario;

        this.Cajero = cajero;

        this.Cocinero = cocinero;

        this.Encargado = encargado;

        this.Camarero = camarero;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RolEN t = obj as RolEN;
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
