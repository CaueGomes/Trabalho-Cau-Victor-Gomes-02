using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Cauê_Victor_Gomes_02
{
    
        static class Gerador
        {
            /*
             *
             *      !!!!!ESTE CÓDIGO NAO PODE SER ALTERADO!!!!!
             *
             */

            private static Random ran = new Random();

            // Retorna uma idade entre 18 e 80 anos

            public static int Idade()
            {
                return ran.Next(18, 81);
            }
            // Gera um cpf no padrao 000.000.000-00
            public static string Cpf()
            {

                string cpf = "";
                for (int i = 1; i < 15; i++)
                {
                    if (i % 4 == 0)
                    {
                        if (i == 12)
                        {
                            cpf += "-";
                        }
                        else
                        {
                            cpf += ".";
                        }
                    }
                    else
                    {
                        cpf += ran.Next(0, 10);
                    }
                }
                return cpf;
            }
            // Escolhe um nome de uma lista (sem sobrenome)
            public static string NomePessoa()
            {
                int escolha = ran.Next(1, 21);
                string nome;

                switch (escolha)
                {
                    case 1:
                        nome = "Adriana";
                        break;
                    case 2:
                        nome = "Madonna";
                        break;
                    case 3:
                        nome = "JoanaDarc";
                        break;
                    case 4:
                        nome = "Sandra";
                        break;
                    case 5:
                        nome = "ElizabethIV";
                        break;
                    case 6:
                        nome = "LaraCroft";
                        break;
                    case 7:
                        nome = "Madalena";
                        break;
                    case 8:
                        nome = "Bruna";
                        break;
                    case 9:
                        nome = "Marlene";
                        break;
                    case 10:
                        nome = "Katia";
                        break;
                    case 11:
                        nome = "Joao";
                        break;
                    case 12:
                        nome = "Carlos";
                        break;
                    case 13:
                        nome = "Guilherme";
                        break;
                    case 14:
                        nome = "Afonso";
                        break;
                    case 15:
                        nome = "Bruno";
                        break;
                    case 16:
                        nome = "Patrick";
                        break;
                    case 17:
                        nome = "Cleber";
                        break;
                    case 18:
                        nome = "Joeslei";
                        break;
                    case 19:
                        nome = "SuperXandao";
                        break;
                    case 20:
                        nome = "Yoda";
                        break;
                    default:
                        nome = "";
                        break;
                }
                return nome;

            }
            // Gera um saldo aleatório
            public static double Saldo()
            {
                double saldo = ran.Next(200, 2000) + ran.NextDouble();
                return saldo;
            }
            // Gera um nome de Empresa
            public static string NomeEmpresa()
            {
                int escolha = ran.Next(0, 10);
                string nome;

                switch (escolha)
                {
                    case 0:
                        nome = "ArrozBelchior";
                        break;
                    case 1:
                        nome = "Tirol";
                        break;
                    case 2:
                        nome = "Oboticario";
                        break;
                    case 3:
                        nome = "DoVale";
                        break;
                    case 4:
                        nome = "Nestle";
                        break;
                    case 5:
                        nome = "ArrozUrbano";
                        break;
                    case 6:
                        nome = "D'Italia";
                        break;
                    case 7:
                        nome = "Sadia";
                        break;
                    case 8:
                        nome = "Coca-Cola";
                        break;
                    case 9:
                        nome = "Nutella";
                        break;
                    default:
                        nome = "";
                        break;
                }
                return nome;
            }


        }
    
}