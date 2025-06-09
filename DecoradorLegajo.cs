using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class DecoradorLegajo:AlumnoDecorado
    {

        public DecoradorLegajo(Ialumno a):base(a)
        {
        }

        public override string mostrarCalificacion()
        {
            
            return base.mostrarCalificacion() + "(" + adicional.getLegajo() + ")";
        }
    }
}
