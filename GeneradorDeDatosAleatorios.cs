using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class GeneradorDeDatosAleatorios
    {
        Random r = new Random();
        //devuelve un numero aleatorio ente 0 y max
        public int numeroAleatorio(int max) {
            return r.Next(0,max);
        }
        //devuelve un string aleatorio del largo de cant
        public string stringAleatorio(int cant)
        {
            string retorno="";
            for (int i = 0; i < cant; i++)
            {
                char c=(char)r.Next(97, 122);
                retorno += c;
            }
            return retorno;
        }
    }
}
