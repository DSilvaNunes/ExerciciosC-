using System;

class Aula51 //Argumentos de entrada do programa
{

    static void Main(string [] args) // string [] args dentro do "Main" para criar lista de argumentos de entrada
    {
        int res = 0;

       if (args.Length > 0)
        {
            Console.WriteLine("Qnte de argumentos{}:", args.Length);

            for(int i = 0; i < args.Length; i++)

            {
                res += Int32.Parse(args[i]);
               
                //Console.WriteLine("Argumento {0}:{1}",i,args[i]);
            }
            Console.WriteLine("Soma",res);
        }

       else 
        {
            Console.WriteLine("Não foram passados argumentos");
        }
    }

}
