using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula15 // SWITCH case 
{
    internal class aula15
    {
        static void Main()
        {
            int tempo = 0;
            char opcao;
            Console.WriteLine("Viagem de Uberaba até Florianópolis");
            Console.WriteLine("Escolha o transporte: A-AVIÃO | C-CARRO | O-ONIBUS");

            opcao = char.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 'A':
                case 'a':

                    tempo = 60;

                    break;

                    case 'C':
                    case 'c':

                    tempo = 480;

                    break;

                    case 'O':
                    case 'o':

                    tempo = 660;

                    break;

                    default:

                    tempo=-1;

                    break;


            }

            if (tempo < 0)
            {
                Console.WriteLine("TRANSPORTE INDISPONÍVEL");
            }
            else
            {
                Console.WriteLine("TEMPO DE TRANSPORTE ESCOLHIDO É: {0} MINUTOS", tempo);
                Console.WriteLine("TEMPO DE TRANSPORTE ESCOLHIDO É: {0} HORA(S)", tempo/60);
            }
        }
    }
}
