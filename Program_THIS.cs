using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula32 // This - ele aponta a variavel correta - vai fazer referencia ao OBJETO "PAI"
{
    static void Main()
    {
        Calculos c = new Calculos(10, 2);
        Console.WriteLine(c.Somar());
        
    }

    class Calculos
    {

        public int v1;
        public int v2;

        public Calculos(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int Somar()
        {
            return v1 + v2;
        }

    }

}     
