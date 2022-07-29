using System;
using System.Collections.Generic;
class Exercicio2_POO // https://www.youtube.com/watch?v=4EVq2HUO3TI&t=921s
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculo da area do retangulo");
        Retangulo ret = new Retangulo();

        Console.WriteLine("Base:");
        ret.Base = double.Parse(Console.ReadLine());

        Console.WriteLine("Altura:");
        ret.Altura = double.Parse(Console.ReadLine());


        ret.ExibeDados();

        Console.ReadKey();


    }
}

class Quadrado
{
    public Quadrado()
    {

       


    }

}

class Retangulo
{

    public Retangulo()
    {
        this.Altura = 0;
        this.Base = 0;

    }

    private double baseretangulo; 

    public double Base
    {
        get { return baseretangulo; }
        set 
        {
            if (value >= 0) baseretangulo = value; 
            else baseretangulo = 0;
        
        }
    }

    private double alturaretangulo;

    public double Altura
    {
        get { return alturaretangulo; }
        set
        {
            if (value >= 0) alturaretangulo = value;
            else alturaretangulo = 0;

        }
    }   

    public double Area
    {
        get { return baseretangulo*alturaretangulo; }
        
    }

    public void ExibeDados()
    {
        Console.WriteLine("Base..:" + Base);
        Console.WriteLine("Altura:" + Altura);
        Console.WriteLine("Area..:" + Area);
    }


}