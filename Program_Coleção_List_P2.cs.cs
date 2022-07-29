using System;
using System.Collections.Generic;

// Coleção List P2 https://www.youtube.com/watch?v=aMbkEvjR0WA&t=6s
// usado sempre que quiser substituir um Array 
//List seria um Array "dinamico"

class Aula58
{
    static void Main(string[] args)
    {
        List<string> carros = new List<string>(); // lista criada
        // List<string> carros2 = new List<string>(); // lista criada
        string[] carros2 = new string[10];

        carros.Add("Fluence");
        carros.Add("Sentra");
        carros.Add("Civic");
        carros.Add("Corolla");
        carros.Add("Civic");

        if (carros.Remove("Corolla"))// remove um elemento na lista
        {
            Console.WriteLine("Corolla removido");
        }
        else
        {
            Console.WriteLine("Corolla ainda está na lista");
        }

        // carros.RemoveAt(0); // remove o carro na posicao indicada

        // carros.Reverse();// inverse a posicao dos elementos

        carros.Sort(); //faz a ordenacao por ordem alfabetica

        int tamanho = carros.Count; //retorna ou define a capacidade de elementos da lista
        Console.WriteLine("tamanho: {0}", tamanho); // conta a qnte de elmentos

        carros.Capacity = 15; // está determinando a capacidade da lista 
        int capacidade = carros.Capacity;               
        Console.WriteLine("capacidade: {0}", capacidade); // conta a capacidade da lista


        string carrosC = "Sentra";
        int posic = 0;
        posic = carros.IndexOf(carrosC); // INDEX OF serve para achar a posicao do elemento pesquisado onde o elemento está

        Console.WriteLine("O carro {0} está na posição {1}", carrosC, posic); // Count conta a qnte de elmentos criados
        
        Console.WriteLine("Quatidade de carros na lista:{0}", carros.Count);

        carros.Insert(1, "Cruize"); // pode inserir elementos na lista em uma posicao determinada 

        int pos2 = carros.LastIndexOf("Civic"); // vai encontrar a posicao do ultimo elemento encontrado - Civic tem 2 posicoes na lista
        Console.WriteLine("O ultimo Civic  está na posição: {0} ", pos2);

       

        //carros2.AddRange(carros); // vai ADICIONAR os elmentos da "Lista Carro" na "Lista Carros2"
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
           
            Console.WriteLine("Carro:{0}", car);
        };
        
        Console.WriteLine("-----------------------------------------------------------------------");

        //carros.CopyTo(carros2, 2); // vai copiar os elmentos da Carros para Carros2 a partir da posição desejada       


        //foreach (string car2 in carros2)
        //{
        //    Console.WriteLine("Carro2:{0}", car2);

        //}

    }
}