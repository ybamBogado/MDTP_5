using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public interface Observador
    {
        public void actualizar(Observado observado);
    }
}
