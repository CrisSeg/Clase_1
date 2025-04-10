using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MDP_1
{
    //Ejercicio 11
    abstract class Persona : Comparable
    {
        protected string nombre;
        protected int dni;

        public Persona(string n, int d) {
            this.nombre = n;
            this.dni = d;
        }

        public abstract string getNombre();

        public abstract int getDni();

        //Implemento la interfaz comparable
        public virtual bool sosIgual(Comparable c)
        {
            return this.dni == ((Persona)c).dni;
        }

        public virtual bool sosMenor(Comparable c)
        {
            return this.dni < ((Persona)c).dni;
        }

        public virtual bool sosMayor(Comparable c)
        {
            return this.dni > ((Persona)c).dni;        }

        public virtual string ToString()
        {
            return $"Nombre= {nombre} , dni= {dni}";
        }
    }
}
