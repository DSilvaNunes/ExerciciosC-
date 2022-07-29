using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula38  // METODOS VIRTUAIS - SAO METODOS QUE TEM O MESMO NOME EM CLASSES DIFERENTES - COM ACOES DIFERENTES 
              // Herança/Ordem de execução dos construtores https://www.youtube.com/watch?v=0Ya17g9g62Y&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=40
{
    // ORDEM É: BASE >>>>>> PARA >>>> DERIVADAS

    class Base
    {
        public Base()
        {
            Console.WriteLine("Construtor da classe base");

        }

        virtual public void info() // ESSE METODO POR SER SOBRESCRITO POR CONTA DO VIRTUAL
        {
            Console.WriteLine("Base");
        }
    }

    class Derivada1 : Base
    {

        public Derivada1()
        {
            Console.WriteLine("Construtor da classe derivada1");

        }


        override public void info() // POR TER O OVERRIDE EM METODO - ELE EXISTE NA CLASSE BASE 
                                    // E ESTA SENDO SOBRESCITO NA CLASSE DERIVADA
        {
            Console.WriteLine("Derivada1");

        }
    }

    class Derivada2 : Derivada1
    {

        public Derivada2()
        {
            Console.WriteLine("Construtor da classe derivada2");

        }

        override public void info() // POR TER O OVERRIDE EM METODO - ELE EXISTE NA CLASSE BASE 
                                    // E ESTA SENDO SOBRESCITO NA CLASSE DERIVADA
        {
            Console.WriteLine("Derivada2");

        }

    }

    static void Main()
    {
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        //derivada2.info();
        // derivada1.info();

        Base Ref;
        Ref = derivada1;
        Ref.info();

        //Base Ref;
        Ref = derivada2;
        Ref.info();



    }

}



   












