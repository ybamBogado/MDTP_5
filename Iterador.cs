using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public interface Iterador
    {
        public void primero();
        public void siguiente();
        public Boolean fin();

        Comparable actual();
    }
}
