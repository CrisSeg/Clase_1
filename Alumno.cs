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
        private int legajo;
        private double promedio;

        public Alumno(string n, int d, int legajo, double promedio): base(n, d)
        {

            this.legajo = legajo;
            this.promedio = promedio;
        }

        //Implemento la clase abstracta Persona
        override public string getNombre()
        {
            return this.nombre;
        }

        override public int getDni()
        {
            return this.dni;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public double getPromedio()
        {
            return this.promedio;
        }

        override public bool sosIgual(Comparable c)
        {
            return this.dni == ((Alumno)c).dni;
        }

        override public bool sosMenor(Comparable c)
        {
            return this.dni < ((Alumno)c).dni;
        }

        override public bool sosMayor(Comparable c)
        {
            return this.dni > ((Alumno)c).dni;
        }

        override public string ToString()
        {
            return base.ToString() + $", Legajo= {legajo}, Promedio= {promedio}";
        }
    }
}
