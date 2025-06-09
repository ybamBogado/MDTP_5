using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public interface Coleccionable:iterable
    {
        public int cuantos();
        public Comparable minimo();
        public Comparable maximo();
        public void agregar(Comparable c);
        public bool contiene(Comparable c);
    }
}
