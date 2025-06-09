using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp5;


namespace ConsoleApp1
{
    public class Numero: Comparable
    {
        private int valor;
        public Numero(int valor)
        {
            this.valor = valor;
        }
        public int getValor()
        {
            return this.valor;
        }
        //implementar comparable
        public bool sosIgual(Comparable c)
        {
            return getValor() == ((Numero)c).getValor();
        }
        public bool sosMenor(Comparable c)
        {
            return getValor() < ((Numero)c).getValor();
        }
        public bool sosMayor(Comparable c)
        {
            return getValor() > ((Numero)c).getValor();
        }
        public override string ToString()
        {
            return valor.ToString();
        }

    }
}
