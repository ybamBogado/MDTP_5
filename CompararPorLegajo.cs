using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    class CompararPorLegajo : EstrategiasDeComparacionAlumno
    {
        public bool sosIgual(Ialumno c1, Ialumno c2)
        {
            return c1.getLegajo()==c2.getLegajo();
        }

        public bool sosMayor(Ialumno c1, Ialumno c2)
        {
            return c1.getLegajo() > c2.getLegajo();
        }

        public bool sosMenor(Ialumno c1, Ialumno c2)
        {
            return c1.getLegajo()<c2.getLegajo();
        }
    }
}
