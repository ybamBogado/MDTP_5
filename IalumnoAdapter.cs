using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodologíasDeProgramaciónI;
namespace tp5
{
    
    //adaptador generico para alumnos I Alumno
    public class IaLumnoAdapter : Student
    {
        private Ialumno a;

        public IaLumnoAdapter(Ialumno alumno)
        {
            a = alumno;
        }
        public bool equals(Student student)
        {
            //verificacion de student
            if (student is IaLumnoAdapter comparado)
            {
                // Comparar con la variable ialumno del adapter
                return this.a.sosIgual(comparado.a);
            }
            return false;
        }

        public bool lessThan(Student student)
        {
            //verificacion de student
            if (student is IaLumnoAdapter comparado)
            {
                // Comparar con la variable ialumno del adapter
                return this.a.sosMenor(comparado.a);
            }
            return false;
        }

        public bool greaterThan(Student student)
        {
            //verificacion de student
            if (student is IaLumnoAdapter comparado)
            {
                // Comparar con la variable ialumno del adapter
                return this.a.sosMayor(comparado.a);
            }
            return false;
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
