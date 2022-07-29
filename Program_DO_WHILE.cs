using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aula21 // Loop DO WHILE / Estruturas de iteração - https://www.youtube.com/watch?v=cIIJ-Gb4k6o&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=23
{
    class aula21 // DO WHILE - garante q pelo menos uma vez os comandos serão executados - o "DO" não garante isso
    {
        static void Main() // METODO MAIN
        {
            int num = 5;
            do 
            {
                Console.WriteLine("Treinamento Douglas - obg, Senhor!");

            } while (num <5);

            string senha = "123";
            string senhausuario;
            int tentativas = 0;


            do
            {
                Console.Clear();
                Console.WriteLine("Digite a senha:");
                senhausuario=Console.ReadLine();
                tentativas++;
                

            } while (senha != senhausuario);

            Console.WriteLine("Senha correta");
            Console.WriteLine("Numero de tentativas: {0}", tentativas);



        }
    }


   


}




