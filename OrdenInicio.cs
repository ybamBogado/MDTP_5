using MetodologíasDeProgramaciónI;
using tp5;

//orden inicio envia el mensaje de aula.comenzar()
public class OrdenInicio : OrdenEnAula1
{
    Aula aula;

    public OrdenInicio(Aula aula)
    {
        this.aula = aula;
    }
    
    public void ejecutar()
    {
        aula.comenzar();
    }
}