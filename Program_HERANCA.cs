using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula34 // HERANÇA 
{
    class Veiculo
    {
        public int rodas;
        public int velMax;
        private bool ligado; // PRIVATE SÓ PODE SER ACESSADO NA PROPRIA CLASSE

        public void ligar()
        { 
        
            ligado = true;
        }

        public void desligar()
        {
            ligado = false;
        }

        public string getLigado()
        {
            if (ligado) 
            
            {
                return "SIM"; 
            }
            else
            {
                return "NÃO";
            }
        }
    }

    class Carro: Veiculo // CARRO VAI HERDAR PROPRIEDADES DA CLASSE VEICULO
    {
        public string nome;
        public string cor; 

        public Carro(string nome, string cor)
        {
           desligar();
            rodas = 4;
            velMax = 120;
            this.nome = nome;
            this.cor = cor; 


        }
        


    }
    
    static void Main()
    {

        Carro c1 = new Carro("Flecha ", "Prata");
        Console.WriteLine("Cor..............:{0}", c1.cor);
        Console.WriteLine("Nome.............:{0}", c1.nome);
        Console.WriteLine("Velocidade Máxima:{0}", c1.velMax);
        Console.WriteLine("Rodas............:{0}", c1.rodas);
        Console.WriteLine("Ligado...........:{0}", c1.getLigado());

    }



}


