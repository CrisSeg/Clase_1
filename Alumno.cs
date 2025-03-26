using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP_1
{
    //Ejercicio 12
    class Alumno : Persona
    {
        private string nombre;
        private Numero dni;
        private Numero legajo;
        private Numero promedio;

        public Alumno(string n, Numero d, Numero legajo, Numero promedio): base(n, d)
        {
            this.nombre = n;
            this.dni = d;
            this.legajo = legajo;
            this.promedio = promedio;
        }

        //Implemento la clase abstracta Persona
        override public string getNombre()
        {
            return this.nombre;
        }

        override public Numero getDni()
        {
            return this.dni;
        }

        public Numero getLegajo()
        {
            return this.legajo;
        }

        public Numero getPromedio()
        {
            return this.promedio;
        }

        override public bool sosIgual(Comparable c)
        {
            return this.legajo.sosIgual(c);
        }

        override public bool sosMenor(Comparable c)
        {
            return this.promedio.sosMenor(c);
        }

        override public bool sosMayor(Comparable c)
        {
            return this.promedio.sosMayor(c);
        }
    }
}
