using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula37 // Herança/Ordem de execução dos construtores https://www.youtube.com/watch?v=n05PirNElZA&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=39
{            // ORDEM É: BASE >>>>>> PARA >>>> DERIVADAS
    
    class Base
    {
        public Base()
        {
            Console.WriteLine("Construtor da classe base");

        }
    }

    class Derivada1:Base
    {

        public Derivada1()
        {
            Console.WriteLine("Construtor da classe derivada1"); 
        }
    }

    class Derivada2 : Derivada1
    {

        public Derivada2()
        {
            Console.WriteLine("Construtor da classe derivada2");
        }
    }

    static void Main()
    {
        Derivada2 derivada2 = new Derivada2();

   
    }



}


