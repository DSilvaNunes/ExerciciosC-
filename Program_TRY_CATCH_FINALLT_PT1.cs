using System;

class Aula52 // Exceções - Try Catch Finally - P1 https://www.youtube.com/watch?v=GgrjBRhhncI
             // tratamento de excessões
{

    static void Main (string[] args)
    {
        int n1,n2,res;   
        res = n1=n2= 0;

        n1 = 10;
        n2 = 0;

        try //bloco que vai executar as operacoes
        {
            res = n1 / n2;
            Console.WriteLine("{0}/{1}={2}", n1, n2, res);
            Console.WriteLine("Sem erro");
        }
        catch(Exception e) // se tiver erro vai entrar no modo catch // faz o tratamento do erro // "e" recebe a execessao
        {   // Exception "pai' das excessões
            Console.WriteLine("Erro.....{0}", e.Message);
            Console.WriteLine("Execessão{0}", e);// messege mostra a mensagem de erro
            Console.WriteLine("Execessão{0}", e.GetType());
        }
       

        

    }

}
