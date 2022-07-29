using System;

class Aula36 //Membros Protected - https://www.youtube.com/watch?v=DgkWEzQsCMw&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=38
{

    class Veiculo //CLASSE BASE
    {
        public int velAtual;
        private int velMax; // SÓ PODE ACESSAR PELA PROPRIA CLASSE
        protected bool ligado; // PERMITE O ACESSO AOS MEMBROS PELAS CLASSES DERIVADAS - TANTO DA BASE QNTO DAS DERIVAS, MAS SOMENTE PELAS CLASSES

        public Veiculo(int velMax) // METODO CONSTRUTOR
        {
            velAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }

        public bool getLigado(){
            return ligado;
        }

        public int getVelMax() { 
        
            return velMax;
        }


    }

    class Carro:Veiculo //CLASSE DERIVADA DE VEICULO
    {
        public string nome;
        public Carro(string nome, int vm):base(vm)
        {
            this.nome = nome;
            ligado=true;

        }


    }

    static void Main()
    {
        Carro carro = new Carro("Foguete",120);

        Console.WriteLine("Nome do carro....:{0}",carro.nome);
        Console.WriteLine("Velocidade Máxima:{0}", carro.getVelMax());
        Console.WriteLine("Está ligado?.....:{0}", carro.getLigado());

    }





}
