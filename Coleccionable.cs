using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP_1
{
    interface Coleccionable
    {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable c);
        bool contiene(Comparable c);
    }
}
