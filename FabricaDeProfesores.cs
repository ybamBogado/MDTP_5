using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class FabricaDeProfesores : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
            return new Profesor(gen.stringAleatorio(4),gen.numeroAleatorio(1000000000), gen.numeroAleatorio(25));
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos led = new LectorDeDatos();
            return new Profesor(led.stringPorTeclado(), led.numeroPorTeclado(), led.numeroPorTeclado());
        }
    }
}
