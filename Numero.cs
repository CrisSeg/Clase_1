using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP_1
{
    class Numero : Comparable
    {
        private int valor;

        public Numero(int valor)
        {
            this.valor = valor;
        }

        public int getValor()
        { return this.valor; }

        //Implemento la interfaz Comparable

        public bool sosIgual(Comparable c)
        {
            return this.valor == ((Numero)c).valor;
        }
        public bool sosMenor(Comparable c){
            return this.valor < ((Numero)c).valor;
        }

        public bool sosMayor(Comparable c)
        {
            return this.valor > ((Numero)c).valor;
        }

        //Implemento la interefaz tostring
        public override string ToString()
        {
            return $"Numero= {valor}";
        }
    }
}
