using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
        public string stringPorTeclado()
        {
            string letra = Console.ReadLine();
            return letra;
        }
    }
}
