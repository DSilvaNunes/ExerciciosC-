using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Carro
{
    private int velMax;

    public int vm 
    {
        get
        {
            return velMax;
        } // GET PROPRIEDADE DE LEITURA - OBTEM O VALOR DA PROPRIEDADE

        set // SET PROPRIEDADE DE ESCRITA - 
        {

         if (velMax < value)
          {
            velMax = 0;
          }
         else if (value>300)
          {
             velMax =300;
          }
         else
          {
             velMax = value;
          }
        
        } 
    }



    public Carro()
    {
        vm = 120;


    }

    //public void vm(int velMax)
    //{
    //    this.velMax = velMax;   
    //}
}



class Aula41 // GET SET
{

    static void Main()
    {
        Carro carro1 = new Carro();
        carro1.vm = 285;
        Console.WriteLine("Velocidade:{0}", carro1.vm);

    }



}