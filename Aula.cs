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

        public void comenzar() 
        {
            Console.WriteLine("Llegó el profesor");
            teacher = new Teacher();
        }

        public void nuevoAlumno(Alumno a)
        {
            if (teacher==null)
            {
                teacher = new Teacher();
            }
            Student s = new ALumnoAdapter(a);
            teacher.goToClass(s);
        }

        public void claseLista()
        {
            if (teacher == null)
            {
                teacher = new Teacher();
            }
            teacher.teachingAClass();
        }
    }
}
