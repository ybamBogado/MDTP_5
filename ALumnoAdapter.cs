using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodologíasDeProgramaciónI;
namespace tp5
{
    public class ALumnoAdapter:Student
    {
        private Ialumno a;

        public ALumnoAdapter(Alumno alumno)
        {
            a=alumno;
        }
        public bool equals(Student student)
        {
            if (student is ALumnoAdapter otherAdapter)
            {
                // Comparar por un atributo único, como el DNI
                return this.a.getDni() == otherAdapter.a.getDni();
            }
            return false;
        }

        public bool lessThan(Student student)
        {
            if (student is ALumnoAdapter otherAdapter)
            {
                // Comparar por calificaciones
                return this.a.getCalificacion() < otherAdapter.a.getCalificacion();
            }
            throw new InvalidOperationException("El objeto no es compatible con la comparación.");
        }

        public bool greaterThan(Student student)
        {
            if (student is ALumnoAdapter otherAdapter)
            {
                // Comparar por calificaciones
                return this.a.getCalificacion() > otherAdapter.a.getCalificacion();
            }
            throw new InvalidOperationException("El objeto no es compatible con la comparación.");
        }
        

        public string getName()
        {
            return a.getNombre();
        }

       
       

        public void setScore(int score)
        {
            a.setCalificacion(score);
        }

        public string showResult()
        {
            Ialumno decorado1 = new DecoradorLegajo(a);
            Ialumno decorado2 = new DecoradorNumerosLetras(decorado1);
            Ialumno decorado3 = new DecoradorAsteriscos(decorado2);
            return decorado3.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return a.responderPregunta(question);
        }
    }
}
