using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class FabricaDeAlumnos:FabricaDeComparables
    {
        
        //metodos de clase
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
            return new Alumno(gen.stringAleatorio(5),gen.numeroAleatorio(1000000000), gen.numeroAleatorio(4000),(double)gen.numeroAleatorio(100));
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos lec = new LectorDeDatos();
            return new Alumno(lec.stringPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado(), (double)lec.numeroPorTeclado());
        }
        

    }
}
