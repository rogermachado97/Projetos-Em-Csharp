using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Controle_De_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira os dados do produto a serem adicionados ao estoque: ");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("");
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("");
            Console.WriteLine("Digite o numero de produtos a serem adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("");
            Console.WriteLine("Digite o numero de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + p);

            Console.ReadLine();



        }
    }
}
