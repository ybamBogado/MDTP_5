using tp5;

class OrdenLlegaAlumno : ordenEnAula2
{
    Aula aula;

    public OrdenLlegaAlumno(Aula aula)
    {
        this.aula = aula;
    }
    public void ejecutar(Comparable c)
    {
        if (c is Ialumno)
        {
            // Si c es un alumno, se envía el mensaje nuevoAlumno al aula.
            Ialumno alumno = (Ialumno)c;
            aula.nuevoAlumno(alumno);
            // Console.WriteLine($"Nuevo alumno: {alumno.getNombre()}, DNI: {alumno.getDni()}, Legajo: {alumno.getLegajo()}");
        }
        else
        {
            Console.WriteLine("El objeto no es un alumno válido.");
        }
        
    }
}
