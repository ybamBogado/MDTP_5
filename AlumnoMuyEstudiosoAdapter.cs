using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    class AlumnoMuyEstudiosoAdapter: Student
    {
        private AlumnoMuyEstudioso a;

        public AlumnoMuyEstudiosoAdapter(AlumnoMuyEstudioso alumno)
        {
            a = alumno;
        }
        public bool equals(Student student)
        {
            if (student is AlumnoMuyEstudiosoAdapter otherAdapter)
            {
                // Comparar por un atributo único, como el DNI
                return this.a.getDni() == otherAdapter.a.getDni();
            }
            return false;
        }

        public bool lessThan(Student student)
        {
            if (student is AlumnoMuyEstudiosoAdapter otherAdapter)
            {
                // Comparar por calificaciones
                return this.a.getCalificacion() < otherAdapter.a.getCalificacion();
            }
            throw new InvalidOperationException("El objeto no es compatible con la comparación.");
        }

        public bool greaterThan(Student student)
        {
            if (student is AlumnoMuyEstudiosoAdapter otherAdapter)
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
            return a.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return a.responderPregunta(question);
        }
    }
}
