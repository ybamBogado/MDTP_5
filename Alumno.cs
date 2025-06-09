using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class Alumno:Persona,Observador, Ialumno
    {
        
        private int legajo;
        private double promedio;
        private int calificacion;
       
        //creo variable para estrategia
        private EstrategiasDeComparacionAlumno estrategia;
        //:base(parametros originales)
        public Alumno(string n,int d, int l, double p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
            this.estrategia = new CompararPorDni();
        }
        public void setEstrategia(EstrategiasDeComparacionAlumno nuevaEstrategia) {
            
            this.estrategia = nuevaEstrategia;
        
        }


        //getters
        //declaracion de metodos de clase abstracta
        //base para usar 
        public override string getNombre(){ return this.nombre; }
        public override int getDni (){ return this.dni; }
        
        public int getLegajo (){ return this.legajo; }
        public double getPromedio(){ return this.promedio; }

        public int getCalificacion() { return this.calificacion; }

        public void setCalificacion(int c) { this.calificacion = c; }
        public void setNombre(string n) { this.nombre = n; }

        //Metodos relacionados a observer
        public void prestarAtencion()
        {
            Console.WriteLine("Prestando atención");
        }

        public void distraerse()
        {
            Random rnd = new Random();
            string [] frases = ["Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel"];
            Console.WriteLine(frases[rnd.Next(0,2)]);
        }
        //Implementacion de comparable
        public override bool sosIgual(Comparable c)
        {
            return this.estrategia.sosIgual(this,(Ialumno)c);
        }
        public override bool sosMenor(Comparable c)
        {
            return this.estrategia.sosMenor(this, (Ialumno)c);
        }
        public override bool sosMayor(Comparable c)
        {
            return this.estrategia.sosMayor(this, (Ialumno)c);
        }
        public override string ToString()
        {
            return $"{nombre} , {dni} , {legajo} , {promedio}";
        }
        //implementacion de Iobservador
        public void actualizar(Observado observado)
        {
            if (((Profesor)observado).Hablando())
            {
                prestarAtencion();
            }
            else
            {
                distraerse();
            }
        }
        //METODOS PRACTICA 4
        public virtual int responderPregunta(int pregunta)
        {
            Random r = new Random();
            return r.Next(1, 3);
        }
        public string mostrarCalificacion()
        {
            return "Nombre: " + this.nombre + "\n Calificacion: " + this.calificacion;
        }
    }
}
