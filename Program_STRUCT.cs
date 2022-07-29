using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Struct - É UM TIPO DE ESTRUTURA QUE PERMITE O ARMAZENAMENTO DE TIPOS DE DADOS DIFERENTES
//Struct - NAO É CLASSE - NAO PODE SER HERDADA, MAS ACEITA CONSTRUTORES

struct Carro
{
    public string marca, modelo, cor;

    public Carro(string marca, string modelo, string cor) // METODO CONSTRUTOR QUE ATRIBUI VALORES AOS ELEMENTOS
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info()
    {
        Console.WriteLine("Marca:.{}", this.marca);
        Console.WriteLine("Modelo:{}", this.modelo);
        Console.WriteLine("Cor:...{}:",this.cor);

    }


}




class Aula44 
{
    static void Main()
    {
        
        Carro c1 = new Carro("Renault","Fluence","Prata" );
        Carro c2 = new Carro("Batmovel", "Trumbler", "Preta");

        //Carro c1;
        //c1.marca = "Nissan";
        //c1.modelo = "Sentra";
        //c1.cor = "Preta";

        // Carro c2;

        c1.info();
        c2.info();

        //Console.WriteLine("Marca:.{}",c1.marca);
        //Console.WriteLine("Modelo:{}",c1.modelo);
        //Console.WriteLine("Cor:...{}:",c1.cor);
    }



}