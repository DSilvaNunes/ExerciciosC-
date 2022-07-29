using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

// Array de estruturas
struct Carro
{
    public string  modelo, cor;  

    public void info()
    {
        
        Console.WriteLine("Modelo:{}", this.modelo);
        Console.WriteLine("Cor:...{}:", this.cor);
        Console.WriteLine("-------------------------------");
    }
}
class Aula45 
{
    static void Main()
    {

        int[] numeros = new int[10];
        Carro[] carros = new Carro[4];

        carros[0].modelo = "Batmóvel";
        carros[0].cor = "Preta";

        carros[1].modelo = "Golf";
        carros[1].cor = "Azul";

        carros[2].modelo = "Jetta";
        carros[2].cor = "Branco";

        carros[3].modelo = "Camaro";
        carros[3].cor = "Amarelo";

        for (int i = 0; i < carros.Length; i++)
        {
            carros[0].info();
            carros[1].info();
            carros[2].info();
            carros[3].info();
        }    


    }

}
