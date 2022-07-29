using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aula29 // Construtores SERA EXECUTADO AUTOMATICAMENTE INSTANCIAR A CLASSE- https://www.youtube.com/watch?v=DqmESqZ6YXQ&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=31
                 // DESTRUTOR SERA EXECUTADO QUANDO A CLASSE FOR DESTRUIDA INSTANCIAR A CLASSE
{
    class aula29
    {
        public class Jogador // escopo global
        {
            public int energia;
            public bool vivo = true;
            public string nome;

            public Jogador(string n) //escopo local METODO COM MESMO NOME DA CLASSE É CHAMADO É O CONSTRUTOR
            {
                energia = 100;
                vivo = true;
                nome = n;
            }

            ~Jogador() // METODO DESTRUTOR
            {
                Console.WriteLine("Jogador foi destruído {0}:", nome);
            }

        }

        static void Main() // METODO MAIN
        {

            string nomedif;
            Console.WriteLine("Digite o nome do jogador 1:");
            nomedif=Console.ReadLine();


            Jogador j1 = new Jogador(nomedif); // istanciou um OBJETO DA CLASSE JOGADOR - CHAMANDO O METODO CONSTRUTOR "JOGADOR" - 
            Jogador j2 = new Jogador("Lugano");
            Jogador j3 = new Jogador("Fabao");


            
            Console.WriteLine(j1.nome);
            Console.WriteLine(j2.nome);
            Console.WriteLine(j3.nome);
        }

    }

}
