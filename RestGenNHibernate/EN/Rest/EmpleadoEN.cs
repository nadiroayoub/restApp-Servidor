
using System;
// Definición clase EmpleadoEN
namespace RestGenNHibernate.EN.Rest
{
public partial class EmpleadoEN
{
/**
 *	Atributo dni
 */
private string dni;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo telefono
 */
private string telefono;



/**
 *	Atributo negocio
 */
private RestGenNHibernate.EN.Rest.NegocioEN negocio;



/**
 *	Atributo rol
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> rol;



/**
 *	Atributo pass
 */
private String pass;






public virtual string Dni {
        get { return dni; } set { dni = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual RestGenNHibernate.EN.Rest.NegocioEN Negocio {
        get { return negocio; } set { negocio = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> Rol {
        get { return rol; } set { rol = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}





public EmpleadoEN()
{
        rol = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.RolEN>();
}



public EmpleadoEN(string dni, string nombre, string apellidos, string telefono, RestGenNHibernate.EN.Rest.NegocioEN negocio, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> rol, String pass
                  )
{
        this.init (Dni, nombre, apellidos, telefono, negocio, rol, pass);
}


public EmpleadoEN(EmpleadoEN empleado)
{
        this.init (Dni, empleado.Nombre, empleado.Apellidos, empleado.Telefono, empleado.Negocio, empleado.Rol, empleado.Pass);
}

private void init (string dni
                   , string nombre, string apellidos, string telefono, RestGenNHibernate.EN.Rest.NegocioEN negocio, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> rol, String pass)
{
        this.Dni = dni;


        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Telefono = telefono;

        this.Negocio = negocio;

        this.Rol = rol;

        this.Pass = pass;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EmpleadoEN t = obj as EmpleadoEN;
        if (t == null)
                return false;
        if (Dni.Equals (t.Dni))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Dni.GetHashCode ();
        return hash;
}
}
}
