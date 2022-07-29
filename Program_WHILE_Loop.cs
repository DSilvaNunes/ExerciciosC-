using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula20 // Loop WHILE / Estruturas de iteraão - qndo n tiver certeza da qnte de vezes que se quer repetir o comando
{
    internal class aula20
    {
        static void Main()  //- https://www.youtube.com/watch?v=8g-G1QT9hCk&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=23
        {
            int[] num = new int[10];

            int i = 0;
            int j = 9;
            
            
            while(i < num.Length)
            {
                num [i] = 0;               
                Console.WriteLine(num[i]);
                i++;

               // num[j] = 9;
               // Console.WriteLine(num[j]);
              //  i--;

            }          
            Console.WriteLine("Fim do loop");

            






        }
    }
}

