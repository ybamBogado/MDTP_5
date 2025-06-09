using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class IteradorDeCola:Iterador
    {
        private Cola c;
        private int idx;

        public IteradorDeCola(Cola c)
        {
            this.c = c;
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
