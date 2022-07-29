using System;
using System.Collections.Generic;
//Coleção Dictionary - relacionar valores atraves de chaves

class Aula55
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> veiculos = new Dictionary<int, string>();

        veiculos.Add(10,"Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinete");

        //veiculos.Clear(); limpa o Dictionary
        //veiculos.Remove(20); remove um elemento da colecao

        Console.WriteLine("Tamanho do Dictionary:{0}", veiculos.Count);

        int chave = 20;

        if (veiculos.ContainsKey(chave))
        {
            Console.WriteLine("A chave {0} esta na colecao", chave);
        }
        else
        {
            Console.WriteLine("A chave {0} NAO esta na colecao", chave);
        }



        // veiculos[15] = "Bicicleta "; //adiciona um elemento na posicao indicada

        string valor = "Bicicleta";

        if (veiculos.ContainsValue(valor))
        {
            Console.WriteLine("A chave {0} esta na colecao", valor);
        }
        else
        {
            Console.WriteLine("A chave {0} NAO esta na colecao", valor);
        }

        Dictionary<int, string>.ValueCollection valores = veiculos.Values;

        foreach (string v in valores)
        {
            Console.WriteLine(v);

        }



        foreach (KeyValuePair<int, string> veic in veiculos)
        {
            Console.WriteLine(veic);

        }

    }
}
