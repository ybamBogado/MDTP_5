using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public abstract class FabricaDeComparables
    {

        public static Comparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1:
                    // opción 1 Numero
                    fabrica = new FabricaDeNumeros(); break;
                case 2:
                    // opción 2 Alumno
                    fabrica = new FabricaDeAlumnos(); break;
                case 3:
                    // opcion 3 profesor
                    fabrica = new FabricaDeProfesores();
                    break;
                case 4:
                    // opcion 4 Alumno estudioso
                    fabrica = new FabricaDeAlumnoMuyEstudioso();
                    break;
                case 5:
                    //opcion 5 ALumno proxy
                    fabrica = new FabricaDeAlumnosProxy();
                    break;
            }
            return fabrica.crearAleatorio();
        }
        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {

                case 1:
                    //opcion 1 numero
                    fabrica = new FabricaDeNumeros();
                    break;
                case 2:
                    //opcion 2 alumnos

                    fabrica = new FabricaDeAlumnos();
                    break;
                case 3:
                    // opcion 3 profesor
                    fabrica = new FabricaDeProfesores();
                    break;
                case 4:
                    // opcion 4 Alumno estudioso
                    fabrica = new FabricaDeAlumnoMuyEstudioso();
                    break;
                case 5:
                    //opcion 5 ALumno proxy
                    fabrica = new FabricaDeAlumnosProxy();
                    break;
            }
            return fabrica.crearPorTeclado();
        }
        //metodo de instancia
        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
    }
}
