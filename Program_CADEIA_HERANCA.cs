using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Aula35 // CadeiaHeranca - https://www.youtube.com/watch?v=QQIUdTYc3sA&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=37
{

    class Veiculo //CLASSE BASE
    {
        public int velMax;
        private int rodas;
        private bool ligado;

        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }

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
            return (ligado ? "sim" : "nao");// operador ternario 
            //RETURN (CONDICAO ? "TRUE": "FALSE") - 
            //'?' É A CONDICIONAL TERNARIA QUE VAI TESTAR AS HIPOTESES
            // SE A PRIMEIRA FOR 'TRUE' RETORNA A PRIMEIRA OPCAO E SE FOR 'FALSE' RETORNA A SEGUNDA

            /*  if(ligado)
              {
                  return "sim";
              }
               else
               {
                   return "nao";
               }*/
        }

        public int getRodas()
        {
            return rodas;
        }

        public void setRodas(int rodas)
        {
            this.rodas = rodas;

            if (rodas < 0)
            {
                this.rodas= 0;
            }
            else if (rodas > 40)
            {
                this.rodas = 40;
            }
            else
            {
                this.rodas = rodas;
            }
        }
    }
    class Carro : Veiculo // CLASSE CARRO(DERIVADA) VAI HERDAR PARAMETROS DA CLASSE BASE VEICULO
    {
        public string nome;
        public string cor;


        public Carro(String nome, string cor) : base(4)
        //CARRO CLASSE DERIVADA                BASE () FAZ REFERENCIA A CLASSE BASE - - SERVE PARA INICIALIZAR O CONSTRUTOR BASE NA CLASSE DERIVADA
        //                                     (4)É O ARGUMENTO DO NUMERO DE RODAS 
        {
            desligar();
            velMax = 120;
            this.nome = nome;
            this.cor = cor;

        }

    }

    class CarroCombate : Carro // CLASSE VEICULO BASE PARA >>> CLASSE CARRO BASE PARA >>> CLASSE CARROCOMBATE

    {
        public int municao;
        public CarroCombate() : base("tank de guerra", "tricolor")
        //metodo construtor    :base (Carro) (NOME e COR)

        {
            municao = 100;
            setRodas(6);
            velMax = 100;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("s10", "prata");
            c1.ligar();
            Console.WriteLine("Cor do veiculo...................{0}", c1.cor);
            Console.WriteLine("Nome do veiculo..................{0}", c1.nome);
            Console.WriteLine("Quantidade de rodas do veiculo...{0}", c1.getRodas());
            Console.WriteLine("Velocidade maxima do veiculo.....{0}", c1.velMax);
            Console.WriteLine("O veiculo está ligado??..........{0}", c1.getLigado());
            

            Console.WriteLine("-------------------------------------------");

            CarroCombate c2 = new CarroCombate();

            Console.WriteLine("Cor do veiculo...................{0}", c2.cor);
            Console.WriteLine("Nome do veiculo..................{0}", c2.nome);
            Console.WriteLine("Quantidade de rodas do veiculo...{0}", c2.getRodas());
            Console.WriteLine("Velocidade maxima do veiculo.....{0}", c2.velMax);
            Console.WriteLine("O veiculo está ligado??..........{0}", c2.getLigado());
            Console.WriteLine("Munição..........................{0}", c2.municao);



        }
    }
}



