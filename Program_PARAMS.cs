using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aula27 // Argumento params - https://www.youtube.com/watch?v=5mptkK4KVZ8&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=29
{
    class aula27
    {
        static void Main() // METODO MAIN
        {
            soma(1,2,3);
            soma();    
            soma(0);

        }

        static void soma(params int[]n)
        {
            int res = 0;

            if (n.Length <1)
            {
                Console.WriteLine("NÃO TEM VALOR PARA SOMAR"); // NAO TEM VALOR PQ É ZERO
            }
            else if (n.Length < 2)
            {
                Console.WriteLine("VALORES INSUFICIENTES PARA SOMA"); // INSUFICIENTE PQ VAI DAR 1
            }

            else
            {
                for(int i = 0; i < n.Length; i++)
                {
                    res+=n[i];
                }
                Console.WriteLine("Soma é igual:{0}", res);

            }


            
        }
    }

}
