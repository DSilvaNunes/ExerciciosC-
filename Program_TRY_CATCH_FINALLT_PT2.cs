using System;

class Aula53 // Exceções - Try Catch Finally - P2 https://www.youtube.com/watch?v=O3fcw00lPmM
             // tratamento de excessões
{

    static void Main(string[] args)
    {
        //int n1, n2, res;
        //res = n1 = n2 = 0;
        //n1 = 10;
        //n2 = 0; // para ter erro basta deixar divisivel por zero
        float area = 0;
                
        try //bloco que vai executar as operacoes
        {
            //res = n1 / n2;
            //Console.WriteLine("{0}/{1}={2}", n1, n2, res);
            //Console.WriteLine("Sem erro");

            //throw new Exception("Forcar erro");//forca o erro com o "throw" mesmo com divisão sem ser ZERO

            area = Area.Retangulo (0f, 5f); // se u, dois dois for iguais a zero a mensagem de erro vai aparecer
            Console.WriteLine("Area do retangulo:{0}", area);



        }
        catch (Exception e) // se tiver erro vai entrar no modo catch // faz o tratamento do erro // "e" recebe a execessao
        {   // Exception "pai' das excessões
            Console.WriteLine("Erro.....{0}", e.Message);
            //Console.WriteLine("Execessão{0}", e);// messege mostra a mensagem de erro
            //Console.WriteLine("Execessão{0}", e.GetType());
        }
        finally // vai ser executao independente se foi disparada a excessão
        {
            Console.WriteLine("Fim do processo");

        }




    }

}

class Area
{

    public static float Retangulo (float bas, float alt)
    {
        if (bas == 0 || alt == 0)
        {
            throw new Exception("base ou altura não podem ser iguais a zero");
        }
        return bas * alt;
    }
 }

