using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class FabricaDeAlumnoMuyEstudioso:FabricaDeComparables
    {
        //metodos de clase
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
            return new AlumnoMuyEstudioso(gen.stringAleatorio(5), gen.numeroAleatorio(1000000000), gen.numeroAleatorio(4000), (double)gen.numeroAleatorio(100));
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos lec = new LectorDeDatos();
            return new AlumnoMuyEstudioso(lec.stringPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado(), (double)lec.numeroPorTeclado());
        }
    }
}
