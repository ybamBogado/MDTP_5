using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    class CompararPorPromedio:EstrategiasDeComparacionAlumno
    {
        public bool sosIgual(Ialumno c1, Ialumno c2)
        {
            return c1.getPromedio() == c2.getPromedio();
        }

        public bool sosMayor(Ialumno c1, Ialumno c2)
        {
            return c1.getPromedio() > c2.getPromedio();
        }

        public bool sosMenor(Ialumno c1, Ialumno c2)
        {
            return c1.getPromedio() < c2.getPromedio();
        }
    }
}
