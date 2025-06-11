using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class Pila : Coleccionable, Ordenable
    {
        //lista de elementos
        private List<Comparable> stack;

        //variables de ordenable
        OrdenEnAula1 ordenInicio, ordenAulaLlena;
        ordenEnAula2 ordenLlegaAlumno;

        //constructor
        public Pila()
        {
            this.stack = new List<Comparable>();
        }

        //apilar
        public void apilar(Comparable c)
        {
            this.stack.Add(c);
            //cuando llega el primer alumno al aula
            if (stack.Count == 1)
            {

                ordenInicio.ejecutar();
                Console.WriteLine("Primer alumno en el aula: " + ((Ialumno)c).getNombre());
            }
            //cuando llega un alumno al aula
            //se ejecuta el comando ordenLlegaAlumno
            //y se le pasa el alumno como parámetro
            ordenLlegaAlumno.ejecutar(c);

            //cuando el aula está llena (llega a 40 alumnos)
            //se ejecuta el comando ordenAulaLlena
            if (stack.Count == 40)
            {

                ordenAulaLlena.ejecutar();
                
            }
            
        }
        //desapilar
        public Comparable desapilar()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("La pila está vacía. No se puede desapilar.");
                return null;
            }
            Comparable ultimo = stack[stack.Count() - 1];
            stack.RemoveAt(stack.Count() - 1);
            return ultimo;
        }

        public int cuantos()
        {
            return this.stack.Count;
        }
        //metodo para revisar el stack
        public Comparable obtenerElemento(int indice)
        {
            return stack[indice];
        }
        public Comparable minimo()
        {
            Comparable min = obtenerElemento(0);

            for (int i = 0; i < cuantos(); i++)
            {
                //si el elemento actual es menor que min
                if (obtenerElemento(i).sosMenor(min))
                {
                    min = obtenerElemento(i);
                }
            }
            return min;
        }

        public Comparable maximo()
        {
            Comparable max = obtenerElemento(0);

            for (int i = 0; i < cuantos(); i++)
            {
                //si el elemento actual es mayor que max
                if (obtenerElemento(i).sosMayor(max))
                {
                    max = obtenerElemento(i);
                }
            }
            return max;
        }
        //agregar comparable
        public void agregar(Comparable c)
        {
            apilar(c);
            //Console.WriteLine("Elemento agregado: " + ((Numero)c).getValor);
        }
        //contiene comparable?

        public bool contiene(Comparable c)
        {
            foreach (Comparable item in stack)
            {
                if (item.sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }

        public Iterador crearIterador()
        {
            return new IteradorDePila(this);
        }

        //interfaz Ordenable (patron command)

        //se invoca cuando llega el primer alumno al aula
        public void setOrdenInicio(OrdenEnAula1 ordenInicio)
        {
            this.ordenInicio = ordenInicio;
        }
        //se invoca cuando llega un alumno al aula
        public void setOrdenLlegaAlumno(ordenEnAula2 ordenLlegaAlumno)
        {
            this.ordenLlegaAlumno = ordenLlegaAlumno;
        }
        //se invoca cuando el aula está llena (llega a 40 alumnos)
        public void setOrdenAulaLlena(OrdenEnAula1 ordenAulaLlena)
        {
            this.ordenAulaLlena = ordenAulaLlena;
        }
                 
    }
}
