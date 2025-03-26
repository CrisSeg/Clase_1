using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP_1
{
    interface Comparable
    {
        bool sosIgual(Comparable c); //Devuelve verdadero si el numero es igual
        bool sosMenor(Comparable c); //Devuelve verdadero si el numero es menor
        bool sosMayor(Comparable c);//Devuelve verdadero si el numero es mayor

    }
}
