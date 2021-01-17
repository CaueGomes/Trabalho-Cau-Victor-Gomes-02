using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Cauê_Victor_Gomes_02
{
    class Fornecedor : ClienteNormal
    {
        public int TipoProduto { get; set; }
        public string Cnpj { get; set; }
        public int QuantidadeFornecidaAoMes { get; set; }
        

        public Fornecedor()
        {

        }
        public Fornecedor(string nome, string cpf, int idade, double saldo, int tipoProduto, string cnpj, int qtdfornecida) : base(nome, cpf, idade, saldo)
        {
            this.TipoProduto = tipoProduto;
            this.QuantidadeFornecidaAoMes = qtdfornecida;
            this.Cnpj = cnpj;
        }

        
        //Definimos os dados do Fornecedor ultilizando a classe Gerador

        public object DefineFornecedor()
        {
            Fornecedor fornecedor = new Fornecedor();

            Console.WriteLine("Digite as informações a seguir:");

            fornecedor.Nome = Gerador.NomeEmpresa();

            Console.WriteLine("Cnpj com pontos:");

            fornecedor.Cnpj = Console.ReadLine();

            Console.WriteLine("Qual o tipo de produto vendido?:\n1 = R$ 5,45\n2 = R$ 6,78\n3 = R$ 1,43\n4 = R$ 2,68\n5 = R$ 3,78\n6 = R$ 2,96");

            fornecedor.TipoProduto = int.Parse(Console.ReadLine());

            Random ran = new Random();

            

            fornecedor.QuantidadeFornecidaAoMes = ran.Next(50, 200);

            return fornecedor;
        }

        //Agora construirmos os metodos para serem ultilizados mais tarde

        
        public void DefinirQuantidadeFornecida(List<Fornecedor> lista02)
        {
            for (int i = 0; i < lista02.Count; i++)
            {
                lista02[i].QuantidadeFornecidaAoMes += lista02[i].QuantidadeFornecidaAoMes;
            }
        }

        public void MostraQTDFornecida()
        {
            
            
                Console.WriteLine("Quantidade fornecida: " + QuantidadeFornecidaAoMes);
            
        }

        //Metodo para mostrar os dados

        public override void MostraDados()
        {
            Console.WriteLine("Nome da empresa: {0}\nCNPJ: {1}\nTipo de produto: {2}", Nome, Cnpj, TipoProduto);
        }

    }
}
    

    

