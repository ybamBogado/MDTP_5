using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class Aula
    {
        Teacher teacher;
        

        //instancia un profesor e imprime un mensaje por consola
        public void comenzar()
        {
            Console.WriteLine("Llegó el profesor");
            teacher = new Teacher();
        }

        //agrega el alumno a la lista de alumnos del teacher
        public void nuevoAlumno(Ialumno a)
        {
            if (teacher == null)
            {
                comenzar();
            }
            Student s = new IaLumnoAdapter(a);
            teacher.goToClass(s);
        }

        //envia mensaje al teacher
        public void claseLista()
        {
            if (teacher == null)
            {
                comenzar();
            }
            teacher.teachingAClass();
        }
    }
}
