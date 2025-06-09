using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    class IteradorDePila : Iterador
    {
        private Pila p;
        private int indice;

        public IteradorDePila(Pila p)
        {
            this.p = p;
            this.primero();
        }

        public bool fin()
        {
            return this.indice>=this.p.cuantos();
        }
        //sirve para ver el elemento sobre el que estamos parados
        public Comparable actual()
        {
            return this.p.obtenerElemento(this.indice);
        }

        public void primero()
        {
            this.indice=0;
        }

        public void siguiente()
        {
            this.indice++;
        }
    }
}
