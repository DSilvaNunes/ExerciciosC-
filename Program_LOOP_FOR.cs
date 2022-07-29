using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula19  // Loop FOR / Estruturas de iteração https://www.youtube.com/watch?v=cG1VokOCoJA&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=21
{
    internal class aula19 //Loop FOR / Estruturas de iteração mais usado qndo se SABE A QUANTIDADE DE VEZES QUE VAI REPETIR
    {
        static void Main()
        {
            // FOR (CONTADOR/INICIALIZADOR - INICIO DA REPETIÇÃO ,DEFINE QTTE DE VEZES QUE VAI REPETIR, INCREMENTO) 
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine(i);
                Console.WriteLine("Teste FOR ++");
            }

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                Console.WriteLine("Teste FOR--");

            }

            int[]num = new int[10];

            for //(int i=0; i < 10; i++) //jeito 1 de usar
                (int i = 0; i<num.Length; i++) // Length(tamanho) vai percorrer todo o array sem perigo de errar no tamanho do array
            {
                num[i] = 0; // num na posicao "zero" recebe zero - e vai testando em todas as posicoes com numero zero
                Console.WriteLine(num[i]);
            }

            int[] num2 = new int[10];
            for (int i = 0; i < num2.Length; i++)
            {
                Console.WriteLine("Valor de num na posição {0}: {1}", i, num2[i]);
            }

        }
    }
}

