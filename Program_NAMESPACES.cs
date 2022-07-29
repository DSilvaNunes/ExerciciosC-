using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections;

//Namespaces - https://www.youtube.com/watch?v=wqHouDVnpwY&t=50s
//Namespaces serve para controlar o escopo - metodo de organização - e pode classificar os elementos dentro dele
namespace Calc1
{
    class Area
    {
        public static float Retangulo(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base e altura não pode ser iguais a zero");
            }
                return bas * alt;


        }
    }
}

    
   


namespace Calc2 // em outro namespace pode ter metodos de mesmo nome - no caso "Area"
{
    class Area
    {
        public static float Retangulo(float bas, float alt)
        {
            if (bas == 0 || alt == 0) 
            {
                throw new Exception("Base e altura não pode ser iguais a zero");
            }
            return bas * alt;


        }
    }
}


class Aula54
{
    public static void Main(string[] args)
    {
        float area = 0;
        try
        {
            area = Calc1.Area.Retangulo(0f, 5f); // esta usando o Calc1 por conta q eles está em namespace diferente
            Console.WriteLine("Area do retangulo: {0}", area);
        }
        catch
        {
            Console.WriteLine("Erro", e.Message);
        }
        finally
        {
            Console.WriteLine("Fim do processo");

        }
    }

}
