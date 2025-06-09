using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class IteradorDeColecciones : Iterador
    {
        private Coleccionable c;
        private int idx;
        public IteradorDeColecciones(Coleccionable c)
        {
            this.c = c;
            this.primero();
        }

        public bool fin()
        {
            return this.idx>=this.c.cuantos();
        }

        public Comparable actual()
        {
            throw new NotImplementedException();
        }

        public void primero()
        {
            this.idx=0;
        }

        public void siguiente()
        {
            this.idx++;
        }
    }
}
