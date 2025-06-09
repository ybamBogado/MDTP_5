using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class FabricaDeAlumnosProxy:FabricaDeComparables
    {
        
        //metodos de clase
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
            return new alumnoProxy(gen.stringAleatorio(5));
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos lec = new LectorDeDatos();
            return new alumnoProxy(lec.stringPorTeclado());
        }
        

    }
}
