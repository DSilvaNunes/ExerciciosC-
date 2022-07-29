using System;
using System.Collections.Generic;

// Coleção List P1 https://www.youtube.com/watch?v=Saa1IPQD0KA&t=1s
// usado sempre que quiser substituir um Array 
//List seria um Array "dinamico"

class Aula57
{
    static void Main(string[]args)
    {
        List<string> carros = new List<string>(); // lista criada
        // List<string> carros2 = new List<string>(); // lista criada
        string[] carros2 = new string[10];

        carros.Add("Fluence");
        carros.Add("Sentra");
        carros.Add("Corolla");
        carros.Add("Civic");

        string carrosC = "Sentra";
        int posic = 0;
        posic = carros.IndexOf(carrosC); // INDEX OF serve para achar a posicao do elemento pesquisado onde o elemento está
        Console.WriteLine("O carro {0} está na posição {1}", carrosC, posic);

        // carros2.AddRange(carros); // vai ADICIONAR os elmentos da "Lista Carro" na "Lista Carros2"
        //carros.Clear(); // LIMPA A LISTA INTEIRA
       



        if (carros.Contains("Sentra")) // Contains retorna TRUE se acha um elemento na lista
        {
            Console.WriteLine("Está na lista"); //TRUE

        }

        else
        {
            Console.WriteLine("Não encontrado"); //FALSE
        }


        foreach (string car in carros)
        {
            //Console.WriteLine(carros.Count); // Count conta a qnte de elmentos criados
            Console.WriteLine("Carro:{0}", car);

        };
        Console.WriteLine("-----------------------------------------------------------------------");

        

        carros.CopyTo(carros2, 2); // vai copiar os elmentos da Carros para Carros2 a partir da posição desejada


        foreach (string car2 in carros2)
        {
            Console.WriteLine("Carro2:{0}",car2);

        }

        
       
    }
}