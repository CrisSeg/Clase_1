using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP_1
{
    class Cola : Coleccionable
    {
        List<Comparable> elementos;

        public Cola()
        {
            this.elementos = new List<Comparable>();
        }

        public void Encolar(Comparable c) {
            this.elementos.Add(c);
        }

        public Comparable Desencolar()
        {
            Comparable aux = elementos[0];
            elementos.RemoveAt(0);
            return aux;
        }

        //Implemento la interfaz Coleccionable
        public int cuantos()
        {
            return this.elementos.Count;
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
                    aux = this.elementos[i];
                }
            }
            return aux;
        }

        public void agregar(Comparable c)
        {
            Encolar(c);
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
