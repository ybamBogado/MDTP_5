using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class DecoradorAsteriscos: AlumnoDecorado
    {
        public DecoradorAsteriscos(Ialumno a) : base(a){}

        public override string mostrarCalificacion()
        {
            int longitud = base.mostrarCalificacion().Length+10;
            string asterisco = new string('*', longitud);
            return asterisco + "\n*\t" + base.mostrarCalificacion() + "\t*\n" + asterisco;
        }
    }
}
