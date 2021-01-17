using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Cauê_Victor_Gomes_02
{
    class ClienteNormal
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public double Saldo { get; set; }

        public ClienteNormal()
        {

        }

        public ClienteNormal(string Nome, string Cpf, int Idade, double Saldo)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Idade = Idade;
            this.Saldo = Saldo;
        }

        //Definindo os dados ultilizando a classe gerador

        public virtual object DefineDados(Object obj)
        {
            Funcionarios func = new Funcionarios();

            ClienteSocio cliSocio = new ClienteSocio();

            ClienteNormal cliNormal = new ClienteNormal();

            if (obj == cliNormal)
            {
                cliNormal.Nome = Gerador.NomePessoa();
                cliNormal.Cpf = Gerador.Cpf();
                cliNormal.Idade = Gerador.Idade();
                cliNormal.Saldo = Gerador.Saldo();

                return cliNormal;
            }
            else if (obj == cliSocio)
            {
                cliSocio.Nome = Gerador.NomePessoa();
                cliSocio.Cpf = Gerador.Cpf();
                cliSocio.Idade = Gerador.Idade();
                cliSocio.Saldo = Gerador.Saldo();

                return cliSocio;
            }
            else
            {
                func.Nome = Gerador.NomePessoa();
                func.Cpf = Gerador.Cpf();
                func.Idade = Gerador.Idade();
                func.Saldo = Gerador.Saldo();

                return func;
            }
            
        }

        //Metodo para Mostrar os Dados

        public virtual void MostraDados()
        {
            Console.WriteLine("Nome: {0}\nCpf: {1}\nIdade: {2}\nSaldo: {3:C}", Nome, Cpf, Idade, Saldo);
        }
    }
}
    

