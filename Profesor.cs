using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class Profesor : Persona, Observado
    {
        public int antiguedad;
        private List<Observador> observadores = new List<Observador>();
        private bool hablando;
        public Profesor(string n, int d, int a) : base(n, d)
        {

            this.antiguedad = a;
        }

        public override string getNombre()
        {
            return this.nombre;
        }
        public override int getDni()
        {
            return this.dni;
        }
        public bool Hablando()
        {
            return this.hablando;
        }

        public int getAntiguedad()
        {
            return this.antiguedad;
        }

        public void hablarALaClase()
        {
            Console.WriteLine("Hablando de algún tema");
            this.hablando = true;
            this.notificar();
        }
        public void escribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarrón");
            this.hablando = false;
            this.notificar();
        }

        

        public void agregarObservador(Observador observador)
        {
            observadores.Add(observador);
        }

        public void quitarObservador(Observador observador)
        {
            observadores.Remove(observador);
        }

        public void notificar()
        {
            foreach (Observador o in observadores)
            {
                //actualizo la instancia actual
                o.actualizar(this);
            }
        }
        //implementacion de observado;
    }
}
