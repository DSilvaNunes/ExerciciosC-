using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aula26 // Argumento out https://www.youtube.com/watch?v=hUwprNIStBw&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=28
{
    class aula26
    {
        static void Main() // METODO MAIN
        {
            int dividend, diviso, quocient, rest;
            dividend = 30;
            diviso = 4;
            quocient = divide(dividend,diviso,out rest);
            Console.WriteLine("{0}/{1}:quociente: {2} e resto {3}", dividend,diviso,quocient,rest);
           

        }

        static int divide (int dividendo, int divisor, out int resto) // OUT É ARGUMENTO DE SAÍDA - PERMITE DUAS SAIDAS DO METODO "DIVIDE": RESTO E QUOCIENTE
        {
            int quociente = 0;            
            quociente = dividendo / divisor;
            resto = dividendo % divisor; // % ele retorna o RESTO da divisao
            return quociente; // RETURN AQUI SÓ PODE RETORNAR UM VALOR  //// EM MATRIZES PODE RETORNAR MAIS DE UM VALOR
            
        }
    }

}
