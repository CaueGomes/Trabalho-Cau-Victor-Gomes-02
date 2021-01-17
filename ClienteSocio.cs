using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Cauê_Victor_Gomes_02
{
    class ClienteSocio : ClienteNormal
    {
        public double qtdAcoes { get; set; }
        public ClienteSocio()
        {

        }
        public ClienteSocio(string Nome, string Cpf, int Idade, double Saldo, double qtdAcoes) : base(Nome, Cpf,Idade, Saldo)
        {
            this.qtdAcoes = qtdAcoes;
        }

        public override object DefineDados(object obj)
        {
            return base.DefineDados(obj);
        }

        //Função para Definir as Ações do Socio

        public double DefineAcoes()
        {
            Random ran = new Random();

            double acoes = ran.Next(0, 5) + ran.NextDouble();

            qtdAcoes = acoes;

            if (qtdAcoes > 4.95)
            {
                qtdAcoes -= .5;
            }

            return qtdAcoes;
        }

        //Mostrando os dados 

        public override void MostraDados()
        {
            base.MostraDados();
        }
        public void MostraAcoes()
        {
            Console.WriteLine("Nome: {0}\nAções: {1:#.##}",Nome, qtdAcoes);
        }
    }
}
