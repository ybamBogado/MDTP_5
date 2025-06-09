using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        Numero n =null;
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios a=new GeneradorDeDatosAleatorios();
            return n = new Numero(a.numeroAleatorio(10));
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos lec = new LectorDeDatos();
            return n = new Numero(lec.numeroPorTeclado());
        }
    }
}
