using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aula28 // Classes e Objetos - https://www.youtube.com/watch?v=8mYnRrUuLj4&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=30

{ 
    class aula28
    {
        static void Main() // METODO MAIN
        {
            Jogador j1 = new Jogador(); // istanciou um OBJETO DA CLASSE JOGADOR
            Jogador j2=  new Jogador();
            Jogador j3 = new Jogador();


            j1.energia = 50;
            j2.energia = 70;
            j3.energia = 90;
            
            Console.WriteLine(j1.energia);
            Console.WriteLine(j2.energia);
            Console.WriteLine(j3.energia);


        }        


        
    }

}
