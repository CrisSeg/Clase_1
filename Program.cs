using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo la pila y la cola
            Pila p = new Pila();
            Cola c = new Cola();

            //Creo una coleccion multiple
            ColeccionMultiple multiple = new ColeccionMultiple(p, c);

            //Aplico los metos de llenar
            llenar(p);
            llenar(c);

            //Aplico los metodos de informar
            informar(p);
            informar(c);
            informar(multiple);
        }

        //Ejercicio 5
        public static void llenar(Coleccionable c)
        {
            Random rmd = new Random();
            for (int i = 0; i < 20; i++)
            {
                Comparable com = new Numero(rmd.Next());
                c.agregar(com);
            }
        }

        //Ejercicio 6
        public static void informar(Coleccionable c)
        {
            Console.WriteLine("La cantidad total de la elementos de la lista es: " + c.cuantos());
            Console.WriteLine("El numero mas chico de la lista es: " + c.minimo());
            Console.WriteLine("El numero mas grande de la lista es: " + c.maximo());

            //Bussco el elemnto que pide el usuario
            Console.WriteLine("Escribar el elemento que desea buscar en la lista: ");
            Comparable aux = new Numero(int.Parse(s: Console.ReadLine()));
            if (c.contiene(aux))
            {
                Console.WriteLine("El elemento leido se encuentra en la lista");
            }
            else
                Console.WriteLine("El elemento leido no se encuentra en la lista");
        }

    }
}


