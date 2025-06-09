using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public interface Ialumno : Comparable
    {
        public void setEstrategia(EstrategiasDeComparacionAlumno nuevaEstrategia);
        public string getNombre();
        public int getDni();
        public int getLegajo();
        public double getPromedio();
        public int getCalificacion();
        public void setCalificacion(int c);
        public void setNombre(string n);
        public void prestarAtencion();
        public void distraerse();
        public int responderPregunta(int pregunta);
        public string mostrarCalificacion();

    }
}
