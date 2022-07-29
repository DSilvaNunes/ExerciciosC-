using System;

class Calc
{
    //public int soma(int n1, int n2)
    //{
    //    return n1 + n2;
    //}

    public int soma(params int[] n)
    //COM O PARAMS PODE-SE INSERIR QTOS ARGUMENTOS QUISER COM O AUXILIO DO ARRAY
    {
        int s = 0;

        for (int i = 0; i < n.Length; i++)
        {
            
            s += n[i];
        }

        return s;
    }


    //public int soma(int n1, int n2,int n3) // SOBRECARGA DO METODO "SOMA" FEITO INSERINDO OUTRO ARGUMENTO ("INT N3")
    //{
    //    return n1 + n2 + n3;
    //}

    //public int soma(int n1, int n2, int n3, int n4) // SOBRECARGA DO METODO "SOMA" FEITO INSERINDO OUTRO ARGUMENTO ("INT N4")
    //{
    //    return n1 + n2 + n3 - n4;
    //}

    //public double soma(double n1, double n2) // SOBRECARGA FEITA MUDANDO O "INT" PELO "DOUBLE"
    //{
    //    return (n1 + n2);
    //}

    public double soma(params double[] n) // SOBRECARGA FEITA MUDANDO O "INT" PELO "DOUBLE"
                       //COM O PARAMS PODE-SE INSERIR QTOS ARGUMENTOS QUISER COM O AUXILIO DO ARRAY
    {
        double s = 0;

        for (double i = 0; i < n.Length; i++)
        {

            s += n[(int)i];
        }

        return s;

        
    }

}

class Aula47
{
    static void Main()
    {
        // int resultado = 0;
        // double resultado2 = 0;
        var resultado3=0;
        

        Calc calc = new Calc(); // objeto "calc" criado

        resultado3 = calc.soma(10, 20);
        Console.WriteLine(resultado3);

        //resultado = calc.soma(10, 20, 30);
        //Console.WriteLine(resultado);

        //resultado = calc.soma(10, 20, 30, 45);
        //Console.WriteLine(resultado);

        resultado3 = (int)calc.soma(3.45, 1.55);
        Console.WriteLine(resultado3);

        


    }
}

