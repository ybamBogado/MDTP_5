using MetodologíasDeProgramaciónI;
using tp5;
public class Program
{
     public static void Main(string[] args)
    {
        //p4ej4
        //instanciar teacher
        Teacher t = new Teacher();
        //instanciar 20 students para que vayan a clase
        for (int i = 0; i < 10; i++)
        {
            Ialumno a = (Ialumno)FabricaDeComparables.crearAleatorio(5);
            Student s = new IaLumnoAdapter(a);
            t.goToClass(s);
        }
        for (int i = 0; i < 10; i++)
        {
            AlumnoMuyEstudioso a = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(4);
            Student s = new IaLumnoAdapter(a);
            t.goToClass(s);
        }
        t.teachingAClass();
    }
}