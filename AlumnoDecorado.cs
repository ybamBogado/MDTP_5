using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public abstract class AlumnoDecorado : Ialumno
    {
        protected Ialumno adicional;
        public AlumnoDecorado(Ialumno a)
        {
            this.adicional = a;
        }

        public void distraerse() { adicional.distraerse(); }
        public int getCalificacion() { return adicional.getCalificacion(); }
        public int getDni() { return adicional.getDni(); }
        public int getLegajo(){ return adicional.getLegajo(); }
        public string getNombre(){ return adicional.getNombre(); }
        public double getPromedio(){ return adicional.getPromedio(); }
        public virtual string mostrarCalificacion(){return adicional.mostrarCalificacion(); }
        public void prestarAtencion(){adicional.prestarAtencion();}
        public int responderPregunta(int pregunta){return adicional.responderPregunta(pregunta); }
        public void setCalificacion(int c){adicional.setCalificacion(c); }
        public void setEstrategia(EstrategiasDeComparacionAlumno nuevaEstrategia){adicional.setEstrategia(nuevaEstrategia);}
        public void setNombre(string n){ adicional.setNombre(n); }

        public bool sosIgual(Comparable c){return adicional.sosIgual(c);}

        public bool sosMayor(Comparable c){return adicional.sosMayor(c);}

        public bool sosMenor(Comparable c){return adicional.sosMenor(c);}
    }
}
