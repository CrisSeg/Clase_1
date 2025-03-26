using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP_1
{
    //Ejercicio 11
    abstract class Persona : Comparable
    {
        protected string nombre;
        protected Numero dni;

        public Persona(string n, Numero d) { }

        public abstract string getNombre();

        public abstract Numero getDni();

        //Implemento la interfaz comparable
        public abstract bool sosIgual(Comparable c);

        public abstract bool sosMenor(Comparable c);

        public abstract bool sosMayor(Comparable c);

    }
}
