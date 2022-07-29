using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
//Métodos que retornam objetos - https://www.youtube.com/watch?v=gmQLuOZ-2g0

class Aula46 
{
    static void Main()
    {
        Galinha galinha1 = new Galinha("Galinha Trombadinha Curintia");
        Galinha galinha2 = new Galinha("Galinha Briguenta");
        Galinha galinha3 = new Galinha("Galinha Tranquila");

        galinha1.botar();
        

        galinha2.botar();
        galinha2.botar();
       

        galinha3.botar();
        galinha3.botar();
        galinha3.botar();
    }

}

class Ovo
{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha) // metodo construtor
    {
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;

        Console.WriteLine("Ovo criado -- {0} - {1}",this.numOvo, this.minhaGalinha);
        
    }
}

class Galinha
{
    private string nomeGalinha;
    private int numOvo;


    public Galinha (string nomeGalinha) // metodo construtor
    {
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public Ovo botar() // metodo" botar" que retorna o objeto " ovo"
    {
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}