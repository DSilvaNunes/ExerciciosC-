using System;

// Métodos e Variáveis estáticos (static) - https://www.youtube.com/watch?v=gMalh0cYbXo
//DECLARAR APENAS OS MEMBROS COMO STATIC E NAO A CLASSE

////////////////////
class Aula49
{
    static void Main() // // Métodos e Variáveis estáticos (static)


    {
        //Matematica m1 = new Matematica(); NAO FOI NECESSARO DECLARAR O OBJETO 

        double vpi = Matematica.pi;
        int num = 10;
        Console.WriteLine(vpi);
        Console.WriteLine(Matematica.dobro(num));
    }
}

class Matematica 
{
    public static double pi = 3.14; // PROPRIEDADE

    public static int dobro (int n) // METODO
    {
        return n*2;
    }

}