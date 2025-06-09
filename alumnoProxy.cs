using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public class alumnoProxy : Ialumno
    {
        Ialumno alumnoReal = null;

        private string nombre;
        public alumnoProxy(string n)
        {
            this.nombre = n;
        }
        public void distraerse()
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");
            }
            alumnoReal.distraerse();
        }

        public int getCalificacion()
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");
            }
            return alumnoReal.getCalificacion();
        }

        public int getDni()
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");
            }
            return alumnoReal.getDni();
        }

        public int getLegajo()
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");
            }
            return alumnoReal.getLegajo();
        }

        public string getNombre()
        {
            return nombre;
        }

        public double getPromedio()
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");
            }
            return alumnoReal.getPromedio();
        }

        public string mostrarCalificacion()
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");
            }
            return alumnoReal.mostrarCalificacion();
        }

        public void prestarAtencion()
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");
            }
            alumnoReal.prestarAtencion();
        }

        public int responderPregunta(int pregunta)
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");
            }
            return alumnoReal.responderPregunta(pregunta);
        }

        public void setCalificacion(int c)
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");
            }
            alumnoReal.setCalificacion(c);
        }

        public void setEstrategia(EstrategiasDeComparacionAlumno nuevaEstrategia)
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");
            }
            alumnoReal.setEstrategia(nuevaEstrategia);
        }

        public void setNombre(string n)
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");

            }
            alumnoReal.setNombre(n);
        }


        public bool sosIgual(Comparable c)
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");
            }
            return alumnoReal.sosIgual(c);
        }
        public bool sosMenor(Comparable c)
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");
            }
            return alumnoReal.sosMenor(c);
        }
        public bool sosMayor(Comparable c)
        {
            if (alumnoReal == null)
            {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("---creando alumno real....");
            }
            return alumnoReal.sosMayor(c);
        }
    }
}
