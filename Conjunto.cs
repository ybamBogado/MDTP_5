using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class Conjunto : Coleccionable
    {
        private List<Comparable> conjunto;

        public Conjunto()
        {
            this.conjunto = new List<Comparable>();
        }

        public void agregar(Comparable c)
        {
            
            if (this.contiene(c))
            {
                conjunto.Add(c);
                Console.WriteLine(c + " agregado");
            }
            else { Console.WriteLine(c + " no agregado"); }
            
        }
        public bool pertenece(Comparable c)
        {
            return this.contiene(c);
        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable item in conjunto)
            {
                if (item.sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }

        public int cuantos()
        {
            return conjunto.Count;
        }

        public Comparable maximo()
        {
            Comparable max = conjunto[0];
            foreach (Comparable item in conjunto)
            {
                if (item.sosMayor(max))
                {
                    max = item;
                }
            }
            return max ;
        }

        public Comparable minimo()
        {
            Comparable min = conjunto[0];
            foreach (Comparable item in conjunto)
            {
                if (item.sosMenor(min))
                {
                    min = item;
                }
            }
            return min;
        }
        public Comparable obtenerElemento(int idx)
        {
            return conjunto[idx];
        }

        public Iterador crearIterador()
        {
            return new IteradorDeConjuntos(this);
        }
    }
}
