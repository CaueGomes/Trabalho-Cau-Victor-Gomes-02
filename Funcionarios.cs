using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Cauê_Victor_Gomes_02
{
    class Funcionarios : ClienteSocio
    {
        public double SaldoPorHora { get; set; }
        public string Cargo { get; set; }
        public bool BaterPontoMes { get; set; }
        public Funcionarios()
        {

        }
        public Funcionarios(string nome, string cpf, int idade, double saldo, double qtdAcoes, double saldoPorHora, string cargo, bool bateu) : base(nome, cpf, idade, saldo, qtdAcoes)
        {
            this.SaldoPorHora = saldoPorHora;
            this.Cargo = cargo;
            this.BaterPontoMes = bateu;
            bateu = false;
        }

        public override object DefineDados(object o)
        {
            return base.DefineDados(o);
        }
        public override void MostraDados()
        {
            base.MostraDados();
        }
        public string DefineCargo()
        {
            //Definimos um cargo aleatorio ultilizando um random

            Random ran = new Random();

            int entrada = ran.Next(1, 5);

            switch (entrada)
            {
                case 1:
                    Cargo = "Caixa";
                    break;

                case 2:
                    Cargo = "Gerente de Estoque";
                    break;

                case 3:
                    Cargo = "Atendente";
                    break;

                case 4:
                    Cargo = "Faxineiro";
                    break;
            }

            SaldoPorHora = ran.Next(5, 40) + ran.NextDouble();

            return Cargo;
        }

        //Metodo para mostrar o Cargo

        public void MostraCargo()
        {
            Console.WriteLine("Nome: {0}\nCargo: {1}\nSalario // Hora: {2:C}",Nome, Cargo, SaldoPorHora);
        }

        //Função para calcular as Horas

        public int BatePonto(int hrEntrada, int hrSaida)
        {
            int horasDeTrabalho = 0;

            if (hrEntrada > hrSaida)
            {
                
                //Calcula as Horas de trabalho se a Hora de entrada > Hora de saida

                horasDeTrabalho = hrEntrada - (hrSaida + 24);
            }
            else
            {
                
                //Calcula as Horas de trabalho se a hora de Saida > Hora de entrada

                horasDeTrabalho = hrEntrada - hrSaida;
            }

            //Retorna as horas trabalhadas transformando em um valor positivo

            return horasDeTrabalho * -1;

        }

        public int DiasTrabalhados()
        {
            //Calcula as horas trabalhadas em 30 dias

            int horasDeTrabalho = 0;

            Random random = new Random();

            for (int i = 0; i < 30; i++)
            {
                horasDeTrabalho += random.Next(7, 10);
            }

            //Retrona as horas de trabalho

            return horasDeTrabalho;
        }







    }
}
    

