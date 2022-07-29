using System;


// Delegates https://www.youtube.com/watch?v=SpEHYVHkcsQ
// OBJETO QUE PODE FAZER REFERENCIA A UM METODO (OU MUITOS) DENTRO DA CLASSE

delegate int Operacao(int n1, int n2);
class Aula50 
{
    static void Main(Operacao matematica)
    {   
        int vsoma, vmulti;
        int resultado;
        

        Operacao delegate1 = new Operacao(Matematica.soma);

        resultado = delegate1(10,50);
        Console.WriteLine("Soma: {0}", resultado);


        delegate1 = new Operacao(Matematica.multiplicacao);
        resultado = delegate1(10, 50);
        Console.WriteLine("Multiplicação: {0}", resultado);       

    }


}

class Matematica 
{
    public static int soma(int n1, int n2)
    {
        return n1 + n2;
    }

    //public static int dobro(int n)
    //{
    //    return n*2;
    //}

    public static int dobro(params int[] n)
    {
        int d = 0;
        for (int i = 0; i < n.Length; i++)
        {
            d = 2 * n[i];
        }
        return d;
    } 

    public static int multiplicacao(int n1, int n2)
    {
         return n1* n2;
    }

}

