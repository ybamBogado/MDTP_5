using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public interface EstrategiasDeComparacionAlumno
    {
        //Estrategia para compare alumnos por  
        //nombre, DNI, promedio y legajo.
        public bool sosIgual(Ialumno c1, Ialumno c2);
        public bool sosMenor(Ialumno c1,Ialumno c2);
        public bool sosMayor(Ialumno c1, Ialumno c2);
    }
}
