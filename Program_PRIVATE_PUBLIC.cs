using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula33 // Public vs Private (pode ser usado APENAS DENTRO DA CLASSE)  
{
    class Jogador
    {
        private int energia;
        private string nome;

        public Jogador(string nome)         
        {
            this.nome = nome;
            energia = 100;
        
        }

        public int getEnergia() // fez o metodo pq é PRIVATE
        {
            return energia;
        }

        public string getNome() // fez o metodo pq é PRIVATE
        {
            return nome;
        }

        public void setEnergia (int ener)
        {

            if (ener <0)
            {
                if (energia +  ener < 0)
                {
                    energia = 0;
                }
                else 
                {
                    energia+=ener;
                }



            } else if (ener > 0)
            {
                if (energia + ener > 100)
                {
                    energia = 100;
                }
                else
                {
                    energia += ener;
                }
            }
        }

    }
    static void Main()
    {
        Jogador j1 = new Jogador("Douglas");
        j1.setEnergia(30);
        j1.setEnergia(-30);

        Console.WriteLine("Nome: {0}", j1.getNome);
        Console.WriteLine("Energia: {0}", j1.getEnergia);

    }  

    

}

