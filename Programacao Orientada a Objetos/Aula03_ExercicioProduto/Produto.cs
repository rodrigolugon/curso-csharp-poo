using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_ExercicioProduto {
    internal class Produto {

        //nome de atributo e classe sao c/ letra MAIUSCULA
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }


    }
}
