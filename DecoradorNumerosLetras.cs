using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class DecoradorNumerosLetras:AlumnoDecorado
    {
        public DecoradorNumerosLetras(Ialumno a) : base(a) { }
        public override string mostrarCalificacion()
        {
            string [] nombre = ["CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"];
            return base.mostrarCalificacion() +"( "+ nombre[base.getCalificacion()]+" )";
        }
    }
}
