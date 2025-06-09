using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public interface Observado
    {
        public void agregarObservador(Observador observador);
        public void quitarObservador(Observador observador);
        public void notificar();
    }
}
