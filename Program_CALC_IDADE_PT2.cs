using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    public class Pessoa
    {
        private int anoNascimento;// variavel que vai armazenar o valor da propriedade

        public int AnoNascimento //PROPRIEDADE
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }

        private string nome;// variavel que vai armazenar o valor da propriedade

        public string Nome //PROPRIEDADE
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome.............:" + this.Nome); // tem q pegar o valor da propriedade e n da variavel que armazena
            Console.WriteLine("Ano de Nascimento:" + this.AnoNascimento);// tem q pegar o valor da propriedade e n da variavel que armazena
            int idade = this.CalculaIdade();
            Console.WriteLine("Idade...........:0" + idade);
        }

        private int CalculaIdade()
        {

            DateTime data = DateTime.Now;
            int ano = data.Year;
            int idade = ano - this.anoNascimento;
            return idade;

        }




    }
}
