using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aula22 //Loop FOREACH / Estruturas de iteração - https://www.youtube.com/watch?v=n3Ns1_F7yUo&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=24
{
    class aula2 //Loop FOREACH ele lê os elementos de uma interação - É INDICADO PARA LEITURA - NÃO SERVE PARA INICIALIZAR
    {
        static void Main() // METODO MAIN
        {
            int[] num = new int[3] { 22, 33, 44 };

           // for(int i = 0; i < num.Length; i++)
           // {
           //    Console.WriteLine(num[i]);
           // }

            foreach (int i in num) // o "i" vai receber cada elemento de "num" 
            {
                Console.WriteLine(i);
            }
            
        }
    }

}
