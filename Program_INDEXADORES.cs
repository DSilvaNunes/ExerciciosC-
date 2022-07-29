using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.youtube.com/watch?v=CU08ERsPYGA&t=1s
//AULA 42 Indexadores de Classes - PERMITEM QUE OBJETOS DENTRO DA CLASSE SEJAM INDEXADOS COMO ARRAYS
class Carro
{
    private int[] velMax = new int[5] {80,120,160,240,300}; // ARRAY FEITO // -----INDEXADOR ----

    public int this[int i]// [int i] FAZ REFERENCIA AO INDICE DO VETOR
    {
        get
        {
            return velMax[i];// retorna o indice do objeito

        } // GET PROPRIEDADE DE LEITURA - OBTEM O VALOR DA PROPRIEDADE

        set // SET PROPRIEDADE DE ESCRITA - 
        {

            if ( value < 0)
            {
                velMax[i] = 0;
            }
            else if (value > 300)
            {
                velMax[i]=300;
            }
            else
            {
                velMax[i] = value;
            }

        }
    }



    public Carro()
    {
       
    }

    //public void vm(int velMax)
    //{
    //    this.velMax = velMax;   
    //}
}



class Aula42 // GET SET
{

    static void Main()
    {
        Carro carro1 = new Carro();
        carro1[4] = 200; 
        Console.WriteLine("Velocidade:{0}", carro1[4]);

    }



}