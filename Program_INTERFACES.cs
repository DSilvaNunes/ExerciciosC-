using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// INTERFACE - ELA SÓ IMPLEMENTA METODOS OU PROTOTIPOS DE METODOS
// NAO USA AS PROPRIEDADES 
// TODA CLASSE QUE IMPLEMENTA A INTERFACE TEM QUE IMPLEMENTAR OS METODOS ("CONTRATO") ENTRE ELES
// UMA CLASSE PODE HERDAR MAIS DE UMA INTERFACE
// NAO PODE TER CONSTRUTOR NEM DESTRUTOR - NAO USA STATIC TAMBÉM
// https://www.youtube.com/watch?v=NSjz4HS7bPU
class Aula43 //INTERFACE
{
    static void Main(string[] args)
    {

        Carro c = new Carro("Fuscão Preto");

        c.disparar();

        c.info();

    }

    public interface Veiculo
    {

        void ligar();
        void desligar();
        void info();

    }

    public interface iCombate // na interface a primeira letra é minuscula
    {

        void disparar();

    }

    class Carro : Veiculo, iCombate
    { // herda os 2 e TEM QUE IMPLEMENTAR TUDO

        public bool ligado;
        private int municao;

        public string nome;

        public void ligar()
        {
            this.ligado = true;
        }

        public void desligar()
        {
            this.ligado = false;
        }

        public void info()
        {
            Console.WriteLine("Nome:...{0}", this.nome);
            Console.WriteLine("Carro:..{0}", this.ligado);
            Console.WriteLine("Municao:{0}", this.municao);

        }
        public void disparar()
        {
            municao -= 30;
        }

        public Carro(string nome)
        {
            this.nome = nome;
            ligado = true;
            setMunicao(100);
        }

        public void setMunicao(int qtde)
        {
            this.municao = qtde;
        }

    }


}