using MetodologíasDeProgramaciónI;
using tp5;
public class Program
{
    //p4_ej4
    //  public static void Main(string[] args)
    // {

    //     //instanciar teacher
    //     Teacher t = new Teacher();
    //     //instanciar 20 students para que vayan a clase
    //     for (int i = 0; i < 10; i++)
    //     {
    //         Ialumno a = (Ialumno)FabricaDeComparables.crearAleatorio(5);
    //         Student s = new IaLumnoAdapter(a);
    //         t.goToClass(s);
    //     }
    //     for (int i = 0; i < 10; i++)
    //     {
    //         AlumnoMuyEstudioso a = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(4);
    //         Student s = new IaLumnoAdapter(a);
    //         t.goToClass(s);
    //     }
    //     t.teachingAClass();
    // }

    //p5_ej10
    //      Ejercicio 10 
    // Implemente una función main que instancie un Aula y una instancia de cada una de las tres 
    // órdenes con el aula como receptor. Instancie una Pila/Cola y seteele las tres órdenes. Luego 
    // llame a la función llenar (práctica 3, ejercicio 6) para agregar 20 instancias de Alumno y 20 
    // instancias de AlumnoMuyEstudioso. 
    public static void Main(string[] args)
    {
        Pila pila = new Pila();
        Aula aula = new Aula();

        pila.setOrdenInicio(new OrdenInicio(aula));
        pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
        pila.setOrdenAulaLlena(new ordenAulaLlena(aula));


        llenar(pila, 2); // OPCION_ALUMNO
        llenar(pila, 4); // OPCION_ALUMNO_MUY_ESTUDIOSO

        Console.WriteLine("se ejecuto correctamente el main");
        Console.ReadKey(true);
    }
    //llenar practica 3, ejercicio 
    public static void llenar(Coleccionable c, int opcion)
    {
        for (int i = 0; i < 40; i++)
        {
            Comparable fabrica = FabricaDeComparables.crearAleatorio(opcion);
            c.agregar(fabrica);
        }
        
    }
}