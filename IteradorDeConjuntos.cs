using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class IteradorDeConjuntos : Iterador
    {
        private Conjunto c;
        private int idx;
        public IteradorDeConjuntos(Conjunto n)
        {
            this.c = n;
            this.primero();
        }

        public bool fin()
        {
            return this.idx >= this.c.cuantos();
        }
        //sirve para ver el elemento sobre el que estamos parados
        public Comparable actual()
        {
            return this.c.obtenerElemento(this.idx);
        }

        public void primero()
        {
            this.idx = 0;
        }

        public void siguiente()
        {
            this.idx++;
        }
    }
}
