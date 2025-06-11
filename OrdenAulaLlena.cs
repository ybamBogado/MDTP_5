using System;
using tp5;
//envía el mensaje claseLista al aula. 
public class ordenAulaLlena : OrdenEnAula1
{
    private Aula aula;

    public ordenAulaLlena(Aula aula)
    {
        this.aula = aula;
    }

    public void ejecutar()
    {
        aula.claseLista();
        Console.WriteLine("se lleno el aula");
    }
}