using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

sealed class Veiculo // NAO PODE SER HERDADA - https://www.youtube.com/watch?v=XHEm3aknA9g&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=42
{


}

class Carro: Veiculo // DA ERRO PQ A CLASSE VEICULO É SEALED 
{

}

class Aula40 // Classe Sealed - CLASSE NAO PODE SER HERDADA
{

    static void Main()
    {
        Carro c1 = new Carro();

    }



}
