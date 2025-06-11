﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class Cola: Coleccionable, Ordenable
    {
        protected List<Comparable>queue;

        //variables de ordenable
        OrdenEnAula1 ordenInicio, ordenAulaLlena;
        ordenEnAula2 ordenLlegaAlumno;

        //constructor
        public Cola()
        {
            this.queue = new List<Comparable>();
        }
        //encolar
        public void encolar(Comparable c)
        {
            this.queue.Add(c);
            //modificaciones para ordenable
            //cuando llega el primer alumno al aula
            if (queue.Count == 1)
            {

                ordenInicio.ejecutar();
            }
            //cuando llega un alumno al aula
            //se ejecuta el comando ordenLlegaAlumno
            //y se le pasa el alumno como parámetro
            ordenLlegaAlumno.ejecutar(c);

            //cuando el aula está llena (llega a 40 alumnos)
            //se ejecuta el comando ordenAulaLlena
            if (queue.Count == 40)
            {

                ordenAulaLlena.ejecutar();
            }
        }
        //desapilar
        public Comparable desapilar()
        {
            //guardar primer elemento
            Comparable primero = queue[0];
            //eliminar primero
            this.queue.RemoveAt(0);
            return primero;
        }
        public int cuantos(){
            return queue.Count;
        }
        //metodo para revisar el queue
        public Comparable obtenerElemento(int indice)
        {
            return queue[indice];
        }
        public Comparable minimo(){
            Comparable min = obtenerElemento(0);

            for (int i = 0; i <cuantos(); i++)
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
            encolar(c);
            //modificaciones para ordenable
            //Console.WriteLine("Elemento agregado: " + ((Numero)c).getValor());
        }
        //contiene comparable?
        public bool contiene(Comparable c)
        {
            foreach (Comparable item in queue)
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
            return new IteradorDeCola(this);
        }

        public void setOrdenInicio(OrdenEnAula1 ordenInicio)
        {
            this.ordenInicio = ordenInicio;
        }

        public void setOrdenLlegaAlumno(ordenEnAula2 ordenLlegaAlumno)
        {
            this.ordenLlegaAlumno = ordenLlegaAlumno;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 ordenAulaLlena)
        {
            this.ordenAulaLlena = ordenAulaLlena;
        }
    }
}
