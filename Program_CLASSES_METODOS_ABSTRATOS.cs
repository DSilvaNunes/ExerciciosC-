using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula39 // Classes e métodos abstratos - https://www.youtube.com/watch?v=2-nHNivx6bA&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=41 
             // SERVE COMO REFERENCIA PARA AS DEMAIS CLASSES QUE VAO HERDAR AS CLASSES ABSTRADAS
             //CRIA SE O PROTOTIPO DE REFERENCIA PARA OS METODOS
             //QUEM HERDAR A CLASSE ABSTRADA É OBRIGADO A IMPLEMENTAR OS METODOS ABSTRATOS E PROPRIEDADES
{
        static void Main()
        {
        Carro carro1= new Carro();

        carro1.aceleracao(10);
        carro1.aceleracao(-1);


        Console.WriteLine(carro1.getVelAtual());

        
        }

}

abstract class Veiculo // CLASSE BASE ABSTRATA
{

    protected int velMax;
    protected int velAtual;
    protected bool ligado;


    public Veiculo()
    {
        ligado = false;
        velAtual = 0;
    }

    public void setLigado(bool ligado)
    {
        this.ligado = ligado;

    }

    public int getVelAtual()
    {
        return velAtual;

    }
    abstract public void aceleracao(int multiplicador);
       
    
}

class Carro : Veiculo
{
    public Carro()
    {
        velMax = 110;

    }

    override public void aceleracao(int multiplicador)
    {
        velAtual += 10 * multiplicador;
    }
}





