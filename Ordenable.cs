using System;
using tp5;

//implemntación de la interfaz Ordenable
// Esta interfaz define los métodos que deben implementarse para establecer órdenes en un aula.
public interface Ordenable
{
    public void setOrdenInicio(OrdenEnAula1 ordenInicio);
    public void setOrdenLlegaAlumno(ordenEnAula2 ordenLlegaAlumno);
    public void setOrdenAulaLlena(OrdenEnAula1 ordenAulaLlena);
}
//se implementa en pila y cola