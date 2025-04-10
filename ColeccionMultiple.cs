using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP_1
{
    class ColeccionMultiple : Coleccionable
    {
        Pila pilas;
        Cola colas;

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.pilas = p;
            this.colas = c;
        }

        //Implemento la interfas coleccionable
        public int cuantos()
        {
            return pilas.cuantos() + colas.cuantos();
        }

        public Comparable minimo()
        {
            Comparable minAct = pilas.minimo();
            Comparable aux1 = colas.minimo();

            minAct = minAct.sosMenor(aux1) ? minAct : aux1;
            return minAct;
        }

        public Comparable maximo() {
            Comparable maxact = pilas.maximo();
            Comparable aux1 = colas.maximo();

            maxact = maxact.sosMayor(aux1) ? maxact : aux1;
            return maxact;
        }

        public void agregar(Comparable c) { }

        public bool contiene(Comparable c)
        {
            return pilas.contiene(c) || colas.contiene(c);
        }
    }
}
