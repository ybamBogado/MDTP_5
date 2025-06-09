using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    class CompararPorNombre:EstrategiasDeComparacionAlumno
    {
        public bool sosIgual(Ialumno c1, Ialumno c2)
        {
            return c1.getNombre() == c2.getNombre();
        }

        public bool sosMayor(Ialumno c1, Ialumno c2)
        {
            return c1.getNombre().Length > c2.getNombre().Length;
        }

        public bool sosMenor(Ialumno c1, Ialumno c2)
        {
            return c1.getNombre().Length < c2.getNombre().Length;
        }
    }
}
