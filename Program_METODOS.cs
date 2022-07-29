using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aula24 // Métodos https://www.youtube.com/watch?v=9A_nFLoRLU8&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=26
{
    class aula24 // Métodos SÃO BLOCOS DE INSTRUÇÕES QUE PODEM SER CHAMADOS - PODEM RETORNAR VALORES OU NÃO
    {
        static void Main() // METODO MAIN
        {

            int v1, v2;
            v1 = Convert.ToInt32(Console.ReadLine());
            v2 = Convert.ToInt32(Console.ReadLine());
            soma(v1 + v2);

           // for (int i = 0; i < 2; i++) 
          //  {
          //      ola();
          //      soma(10,5);              
                
          //  }
            
        }

        static void ola () // metodo simpkes sem entrada de valores
        {
            Console.WriteLine("Curso Douglas - obg, Senhor!");
            
        }

        static void soma(int n1=0,int n2=0,int resultado=0)
        {
            resultado=n1 + n2;
            Console.WriteLine("A soma de N1 {0} e N2 {1} é: {2} ", n1,n2,resultado);
        }

        

    }

}
