
using System;
// Definición clase DueñoEN
namespace RestGenNHibernate.EN.Rest
{
public partial class DueñoEN
{
/**
 *	Atributo dni
 */
private int dni;



/**
 *	Atributo empresa
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.EmpresaEN> empresa;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo apellido
 */
private string apellido;



/**
 *	Atributo telefono
 */
private string telefono;



/**
 *	Atributo pass
 */
private String pass;






public virtual int Dni {
        get { return dni; } set { dni = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.EmpresaEN> Empresa {
        get { return empresa; } set { empresa = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Apellido {
        get { return apellido; } set { apellido = value;  }
}



public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}





public DueñoEN()
{
        empresa = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.EmpresaEN>();
}



public DueñoEN(int dni, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.EmpresaEN> empresa, string nombre, string apellido, string telefono, String pass
               )
{
        this.init (Dni, empresa, nombre, apellido, telefono, pass);
}


public DueñoEN(DueñoEN dueño)
{
        this.init (Dni, dueño.Empresa, dueño.Nombre, dueño.Apellido, dueño.Telefono, dueño.Pass);
}

private void init (int dni
                   , System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.EmpresaEN> empresa, string nombre, string apellido, string telefono, String pass)
{
        this.Dni = dni;


        this.Empresa = empresa;

        this.Nombre = nombre;

        this.Apellido = apellido;

        this.Telefono = telefono;

        this.Pass = pass;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DueñoEN t = obj as DueñoEN;
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
