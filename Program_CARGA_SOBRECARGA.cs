using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aula30 //Sobrecarga de Construtores - https://www.youtube.com/watch?v=1FAicpgPCO4&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=32&ab_channel=CFBCursos
                 // vai adicionando informações ao método de acordo com a necessidade
                 // os nomes podem ser iguais, mas os parametros devem ser diferentes
{
    class aula30
    {
        public class Jogador // escopo global
        {
            public int energia;
            public bool vivo = true;
            public string nome;

            public Jogador() //escopo local METODO COM MESMO NOME DA CLASSE É CHAMADO É O CONSTRUTOR
            {
                energia = 100;
                vivo = true;
                nome = "Jogador";
            }

            public Jogador(string n) //escopo local METODO COM MESMO NOME DA CLASSE É CHAMADO É O CONSTRUTOR
            {
                energia = 100;
                vivo = true;
                nome = n;
            }

            public Jogador(string n, int e) //escopo local METODO COM MESMO NOME DA CLASSE É CHAMADO É O CONSTRUTOR
            {
                energia = e;
                vivo = true;
                nome = n;
            }

            public Jogador(string n, int e, bool v) //escopo local METODO COM MESMO NOME DA CLASSE É CHAMADO É O CONSTRUTOR
            {
                energia = e;
                vivo = v;
                nome = n;
            }

            public void info()
            {
                Console.WriteLine("Imprime nome jogador:{0}",nome);
                Console.WriteLine("Imprime energia jogador:{0}", energia);
                Console.WriteLine("Imprime estado do jogador:{0} \n", vivo);

            }

        }

        static void Main() // METODO MAIN
        {

        
            Jogador j1 = new Jogador(); // istanciou um OBJETO DA CLASSE JOGADOR - CHAMANDO O METODO CONSTRUTOR "JOGADOR" - 
            Jogador j2 = new Jogador("Douglas");
            Jogador j3 = new Jogador("Brenna", 100);
            Jogador j4 = new Jogador("Julie", 300, true);

            j1.info();
            j2.info();
            j3.info();
            j4.info();


        }

    }

}
