using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace projeto010
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {

        }
        public override string ToString()
        {
         
            return Nome
            + ",$ "
            + Preco.ToString("F2, CultureInfo.InvariantCulture")
            + ", "
            + Quantidade
            + "unidades,Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            
        }
    }
}
