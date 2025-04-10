using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP_1
{
    class Pila : Coleccionable
    {
        List<Comparable> elementos;

        public Pila()
        {
            this.elementos = new List<Comparable>();
        }

        public void Apilar(Comparable c)
        {
            this.elementos.Add(c);
        }

        public Comparable DesApilar()
        {
            Comparable aux = elementos[elementos.Count-1];
            elementos.RemoveAt(elementos.Count - 1);
            return aux;
        }

        //Aplico la interfas coleccionable
        public int cuantos()
        {
            return elementos.Count;
        }

        public Comparable minimo()
        {
            Comparable aux = this.elementos[0];
            for (int i = 1; i < this.cuantos(); i++)
            {
                if (this.elementos[i].sosMenor(aux))
                {
                    aux = this.elementos[i];
                }
            }
            return aux;
        }

        public Comparable maximo()
        {
            Comparable aux = this.elementos[0];
            for (int i = 1; i < this.cuantos(); i++)
            {
                if (this.elementos[i].sosMayor(aux))
                {
                    aux = elementos[i];    
                }
            }
            return aux;
        }

        public void agregar(Comparable c)
        {
            Apilar(c);
        }

        public bool contiene(Comparable c)
        {
            for (int i = 0; i < this.cuantos(); i++)
            {
                if (this.elementos[i].sosIgual(c))
                {
                    return this.elementos[i].sosIgual(c);
                }
            }
            return false;
        }

    }
}
