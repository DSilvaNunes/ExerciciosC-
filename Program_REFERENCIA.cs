using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aula25 // Passagem por valor e por referência
{
    class aula25
    {
        static void Main() // METODO MAIN
        {
            int num = 10;
            dobrar(ref num); // tem que usar o REF para apontar o endereço de memoria da variavel para fazer o uso do METODO
            Console.WriteLine(num);
        }

        static void dobrar(ref int valor) // tem que usar o REF para apontar o endereço de memoria da variavel 
        {
            valor*=2;
        }
    }

}
