using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    class CompararPorDni:EstrategiasDeComparacionAlumno
    {
        public bool sosIgual(Ialumno c1, Ialumno c2)
        {
            return c1.getDni() == c2.getDni();
        }

        public bool sosMayor(Ialumno c1, Ialumno c2)
        {
            return c1.getDni() > c2.getDni();
        }

        public bool sosMenor(Ialumno c1, Ialumno c2)
        {
            return c1.getDni() < c2.getDni();
        }
    }
}
