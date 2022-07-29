using System;
using System.Collections.Generic;
//Coleção Queue (Fila) - primeiro a elemento a ser adicionado é o primeiro a sair
//First in First out - https://www.youtube.com/watch?v=RdNbnZ7ioF4
//apenas o primeiro elemento é manipulável

class Aula59
{
    public static void Main(string[] args)
    {
        //string[] vs = { "carro", "moto", "navio", "avião" }; pode inicializar a Queue com array
        //Queue<string> veiculos = new Queue<string>(vs);

        Queue<string> equipeF1 = new Queue<string>();

        equipeF1.Enqueue("Mercedes"); // Enqueue adiciona no final da fila
        equipeF1.Enqueue("Red Bull");
        equipeF1.Enqueue("Ferrari");
        equipeF1.Enqueue("MClaren");

        string monoposto = "Red Bull";
        
      
        if (equipeF1.Contains(monoposto)) // Contains VERIFICA SE O ELEMENTO ESTÁ NA FILA
        {
            Console.WriteLine("Equipe encontrada:{0}", monoposto);
        }
        else
        {
            Console.WriteLine("Equipe não está na fila:{0}", monoposto);
        }

        //equipef1.Clear(); // limpa a fila

        //Console.WriteLine("Primeira equipe" + equipef1.Dequeue()); // RETIRA O PRIMEIRO ELEMENTO DA FILA E RETONA
        //Console.WriteLine("Primeira equipe: {0}", equipef1.Peek()); // PEEK RETORNA O PRIMEIRO ELEMENTO SEM EXCLUIR
        //Console.WriteLine("Quantidade de elementos: {0}", equipeF1.Count); /*COUNT FAZ A CONTAGEM DE ELEMENTOS NA FILA*/

        //foreach (string v in equipeF1) // ler os elementos da fila
        //{
        //    Console.WriteLine("Equipe:{0}",v);
        //}

        while(equipeF1.Count > 0)
        {
            Console.WriteLine(equipeF1.Dequeue()); // foi retirando até a qnte de elementos ficar zero
        }
        Console.WriteLine("Tamanho da fila: " + equipeF1.Count); //monstra a qnte de elementos igual a zero


    }
}
