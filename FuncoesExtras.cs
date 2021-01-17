using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Cauê_Victor_Gomes_02
{
    class FuncoesExtras : Fornecedor
    {


        //Criamos varias funções em um objeto separado para facilitar a checagem de cpf/cnpj iguais
        //Desta forma, precisamos apenas puxar elas para o programa quando quisermos fazer a verificação

        
        //Verificar Cpf dos clientes normais 


            public void VerificarCpfClienteNormal(List<ClienteNormal> clientesNormais)
            {
                for (int j = 1; j < clientesNormais.Count; j++)
                {
                    for (int i = 0; i < clientesNormais.Count - 1; i++)
                    {
                        if (clientesNormais[i].Cpf.CompareTo(clientesNormais[i + 1].Cpf) == 0)
                        {
                            Console.WriteLine("O Cpf já existe, por favor insira outro");
                            clientesNormais[i + 1].Cpf = Gerador.Cpf();
                        }
                    }
                }
            }

        //Verificar o Cpf dos clientes socios


            public void VerificarCpfClienteSocio(List<ClienteSocio> clienteSocios)
            {
                for (int j = 1; j < clienteSocios.Count; j++)
                {
                    for (int i = 0; i < clienteSocios.Count - 1; i++)
                    {
                        if (clienteSocios[i].Cpf.CompareTo(clienteSocios[i + 1].Cpf) == 0)
                        {
                            Console.WriteLine("O Cpf já existe, por favor insira outro");

                            clienteSocios[i + 1].Cpf = Gerador.Cpf();
                        }
                    }
                }
            }


        //Verificar o Cpf dos funcionarios


            public void VerificarCpfFuncionarios(List<Funcionarios> clienteFunc)
            {
                for (int j = 1; j < clienteFunc.Count; j++)
                {
                    for (int i = 0; i < clienteFunc.Count - 1; i++)
                    {
                        if (clienteFunc[i].Cpf.CompareTo(clienteFunc[i + 1].Cpf) == 0)
                        {
                            Console.WriteLine("O Cpf já existe, por favor insira outro");

                            clienteFunc[i + 1].Cpf = Gerador.Cpf();
                        }
                    }
                }
            }


        //Verificar o Cnpj dos fornecedores


            public void VerificarCnpj(List<Fornecedor> fornecedors)
            {
                for (int j = 1; j < fornecedors.Count; j++)
                {
                    for (int i = 0; i < fornecedors.Count - 1; i++)
                    {
                        if (fornecedors[i].Cnpj.CompareTo(fornecedors[i + 1].Cnpj) == 0)
                        {
                            Console.WriteLine("O Cnpj já existe, por favor insira outro");

                            fornecedors[i + 1].Cnpj = Console.ReadLine();
                        }
                    }

                }
            }

       



        //Adiciona os clientes normais


            public void AdicionarClienteNormal(List<ClienteNormal> lista01)
            {

                ClienteNormal clientenormal = new ClienteNormal();

                object obj = clientenormal.DefineDados(clientenormal);

                lista01.Add((ClienteNormal)obj);

                VerificarCpfClienteNormal(lista01);

                Console.WriteLine("Um novo cliente do tipo Normal foi adicionado com sucesso.");
            }

        //Adiciona cliente do tipo Socio


        public void AdicionarClienteSocio(List<ClienteSocio> lista02)
        {
            ClienteSocio clienteSocio = new ClienteSocio();

            if (lista02.Count >= 10)
            {
                Console.WriteLine("O numero de clientes Socios já chegou no limite!");
            }
            else
            {
                object obj = clienteSocio.DefineDados(clienteSocio);

                clienteSocio = (ClienteSocio)obj;

                clienteSocio.qtdAcoes = clienteSocio.DefineAcoes();

                lista02.Add(clienteSocio);

                VerificarCpfClienteSocio(lista02);

                Console.WriteLine("Um novo cliente do tipo Socio foi adicionado com sucesso!");
            }
        }


        //Adiciona funcionarios


        public void AdicionarFuncionario(List<Funcionarios> lista03)
        {
            Funcionarios funcionario = new Funcionarios();

            funcionario.Nome = Gerador.NomePessoa();

            funcionario.Cpf = Gerador.Cpf();

            funcionario.Idade = Gerador.Idade();

            funcionario.DefineCargo();

            lista03.Add(funcionario);

            VerificarCpfFuncionarios(lista03);

            Console.WriteLine("Um novo Funcionario foi adicionado com sucesso!");
        }


        //Adiciona fornecedor


        public void AdicionarFornecedor(List<Fornecedor> lista04)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor = (Fornecedor)fornecedor.DefineFornecedor();

            lista04.Add(fornecedor);

            VerificarCnpj(lista04);

            Console.WriteLine("Um novo fornecedor foi adicionado com sucesso!");

            MostrarDadosFornecedor(lista04);

            
        }


        //Agora para remover, começando pelos clientes normais


        public void RemoverClienteNormal(List<ClienteNormal> clienteNormais, string Cpf)
        {
            bool temporaria = true;

            for (int i = 0; i < clienteNormais.Count; i++)
            {
                if (clienteNormais[i].Cpf.CompareTo(Cpf) == 0)
                {
                    clienteNormais.RemoveAt(i);

                    Console.WriteLine("Um cliente do tipo normal foi removido com sucesso!");

                    temporaria = true;

                    break;
                }
                else
                {
                    temporaria = false;
                }
            }
            if (temporaria == false)
            {
                Console.WriteLine("Não foi possivel encontrar o cpf requisitado no sistema!");
            }
            foreach (var item in clienteNormais)
            {
                item.MostraDados();
            }
        }

        //Remover Clientes socios


        public void RemoverClienteSocio(List<ClienteSocio> clienteSocio, string Cpf)
        {
            bool temporaria = true;
            for (int i = 0; i < clienteSocio.Count; i++)
            {
                if (clienteSocio[i].Cpf.CompareTo(Cpf) == 0)
                {

                    Console.WriteLine("Um cliente do tipo socio foi removido com sucesso!");

                    clienteSocio.RemoveAt(i);

                    temporaria = true;

                    break;
                }
                else
                {
                    temporaria = false;
                }
            }
            if (temporaria == false)
            {
                Console.WriteLine("O cpf requisitado não foi encontrado no sistema!");
            }
            foreach (var item in clienteSocio)
            {
                item.MostraDados();

                Console.WriteLine();

                item.MostraAcoes();
            }
        }

        //Remover Funcionarios


        public void RemoverFuncionario(List<Funcionarios> clienteFunc, string Cpf)
        {
            bool temporaria = true;
            for (int i = 0; i < clienteFunc.Count; i++)
            {
                if (clienteFunc[i].Cpf.CompareTo(Cpf) == 0)
                {
                    Console.WriteLine("Um funcionario foi removido com sucesso!");

                    clienteFunc.RemoveAt(i);

                    temporaria = true;

                    break;
                }
                else
                {
                    temporaria = false;
                }
            }
            if (temporaria == false)
            {
                Console.WriteLine("O cpf requisitado não foi encontrado no sistema!");
            }
            foreach (var item in clienteFunc)
            {
                item.MostraDados();

                Console.WriteLine();

                item.MostraCargo();
            }
        }

        //Remover Fornecedor


        public void RemoverFornecedor(List<Fornecedor> clienteForn, string Cnpj)
        {
            bool temporaria = true;

            for (int i = 0; i < clienteForn.Count; i++)
            {
                if (clienteForn[i].Cnpj.CompareTo(Cnpj) == 0)
                {
                    Console.WriteLine("Um fornecedor foi removido com sucesso!");

                    clienteForn.RemoveAt(i);

                    temporaria = true;

                    break;
                }
                else
                {
                    temporaria = false;
                }
            }
            if (temporaria == false)
            {
                Console.WriteLine("O cnpj requisitado não foi encontrado no sistema!");
            }
            foreach (var item in clienteForn)
            {
                item.MostraDados();
            }
        }


        //Agora fazemos as compras de acordo com o tipo do cliente, começando pelo normal

        public void ComprarClienteNormal(List<ClienteNormal> lista01, string Cpf, List<Fornecedor> fornecedores)
        {
            bool temporaria = true;

            for (int i = 0; i < lista01.Count; i++)
            {
                if (lista01[i].Cpf.CompareTo(Cpf) == 0)
                {
                    Console.WriteLine("Qual o valor que irá comprar?");

                    double entrada = double.Parse(Console.ReadLine());

                    lista01[i].Saldo += entrada;

                    for (int j = 0; j < fornecedores.Count; j++)
                    {
                        switch (fornecedores[j].TipoProduto)
                        {
                            case 1:
                                fornecedores[j].Saldo = fornecedores[j].QuantidadeFornecidaAoMes * 5.45;

                                break;

                            case 2:
                                fornecedores[j].Saldo = fornecedores[j].QuantidadeFornecidaAoMes * 6.78;

                                break;

                            case 3:
                                fornecedores[j].Saldo = fornecedores[j].QuantidadeFornecidaAoMes * 1.43;

                                break;

                            case 4:
                                fornecedores[j].Saldo = fornecedores[j].QuantidadeFornecidaAoMes * 2.68;

                                break;

                            case 5:
                                fornecedores[j].Saldo = fornecedores[j].QuantidadeFornecidaAoMes * 3.78;

                                break;

                            case 6:
                                fornecedores[i].Saldo = fornecedores[j].QuantidadeFornecidaAoMes * 2.96;

                                break;
                        }

                    }
                    temporaria = true;
                    break;
                }
                else
                {
                    temporaria = false;
                }
            }
            if (temporaria == false)
            {
                Console.WriteLine("Não foi possivel encontrar um cliente!");
            }
            Console.WriteLine("Sua compra foi realizada com sucesso!");
        }

        //Agora com os Clientes socios

        public void ComprarClienteSocio(List<ClienteSocio> lista02, string Cpf, List<Fornecedor> fornecedores)
        {
            bool temporaria = true;

            for (int i = 0; i < lista02.Count; i++)
            {
                if (lista02[i].Cpf.CompareTo(Cpf) == 0)
                {
                    Console.WriteLine("Qual o valor que irá comprar?");

                    double entrada = Convert.ToDouble(Console.ReadLine());

                    double entrada02 = entrada * 0.2;

                    entrada = entrada - entrada02;

                    lista02[i].Saldo += entrada;

                    for (int j = 0; j < fornecedores.Count; j++)
                    {
                        fornecedores[j].QuantidadeFornecidaAoMes = int.Parse(Console.ReadLine());

                        switch (fornecedores[j].TipoProduto)
                        {
                            case 1:
                                fornecedores[j].Saldo = fornecedores[j].QuantidadeFornecidaAoMes * 5.45;

                                break;

                            case 2:
                                fornecedores[j].Saldo = fornecedores[j].QuantidadeFornecidaAoMes * 6.78;

                                break;

                            case 3:
                                fornecedores[j].Saldo = fornecedores[j].QuantidadeFornecidaAoMes * 1.43;

                                break;

                            case 4:
                                fornecedores[j].Saldo = fornecedores[j].QuantidadeFornecidaAoMes * 2.68;

                                break;

                            case 5:
                                fornecedores[j].Saldo += fornecedores[j].QuantidadeFornecidaAoMes * 3.78;

                                break;

                            case 6:
                                fornecedores[j].Saldo = fornecedores[j].QuantidadeFornecidaAoMes * 2.96;

                                break;
                        }
                    }

                    temporaria = true;

                    break;
                }
                else
                {
                    temporaria = false;
                }
            }
            if (temporaria == false)
            {
                Console.WriteLine("Não foi possivel encontrar um cliente!");
            }
            Console.WriteLine("Sua compra foi realizada com sucesso!");
        }

        

        //Agora para alterar os clientes, começando pelo normal

        public void AlterarClienteNormal(List<ClienteNormal> lista01, string Cpf)
        {
            bool temporaria = true;
            for (int i = 0; i < lista01.Count; i++)
            {
                if (lista01[i].Cpf.CompareTo(Cpf) == 0)
                {
                    Console.WriteLine("Preencha os dados a seguir: ");

                    Console.WriteLine("Nome:");

                    lista01[i].Nome = Console.ReadLine();

                    Console.WriteLine("Cpf com pontos: ");

                    lista01[i].Cpf = Console.ReadLine();

                    Console.WriteLine("Idade: ");

                    lista01[i].Idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Saldo: ");

                    lista01[i].Saldo = double.Parse(Console.ReadLine());

                    temporaria = true;

                    break;
                }
                else
                {
                    temporaria = false;
                }
            }
            if (temporaria == false)
            {
                Console.WriteLine("Não foi possivel encontrar o cpf no sistema");
            }

            MostrarDadosClienteNormal(lista01);
        }

        //Agora para alterar o cliente socio


        public void AlterarClienteSocio(List<ClienteSocio> lista02, string Cpf)
        {
            bool temporaria = true;

            for (int i = 0; i < lista02.Count; i++)
            {
                if (lista02[i].Cpf.CompareTo(Cpf) == 0)
                {
                    Console.WriteLine("Preecha os dados a seguir:");

                    Console.WriteLine("Nome:");

                    lista02[i].Nome = Console.ReadLine();

                    Console.WriteLine("Cpf com pontos: ");

                    lista02[i].Cpf = Console.In.ReadLine();

                    Console.WriteLine("Idade: ");

                    lista02[i].Idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Saldo: ");

                    lista02[i].Saldo = double.Parse(Console.ReadLine());

                    Console.WriteLine("Quantidade de ações: ");

                    lista02[i].qtdAcoes = double.Parse(Console.ReadLine());

                    if (lista02[i].qtdAcoes > 4.95)
                    {
                        lista02[i].qtdAcoes = 0;
                    }

                    temporaria = true;

                    break;
                }
                else
                {
                    temporaria = false;
                }
            }
            if (temporaria == false)
            {
                Console.WriteLine("Cpf não encontrado no sistema!");
            }

            MostrarDadosClienteSocio(lista02);
        }

        //Metodo para alterar dados dos funcionarios

        public void AlterarFuncionario(List<Funcionarios> lista03, string Cpf)
        {
            bool temporaria = true;

            for (int i = 0; i < lista03.Count; i++)
            {
                if (lista03[i].Cpf.CompareTo(Cpf) == 0)
                {
                    Console.WriteLine("Preencha os dados a seguir:");

                    Console.WriteLine("Nome:");

                    lista03[i].Nome = Console.ReadLine();

                    Console.WriteLine("Cpf com pontos: ");

                    lista03[i].Cpf = Console.In.ReadLine();

                    Console.WriteLine("Idade: ");

                    lista03[i].Idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Saldo: ");

                    lista03[i].Saldo = double.Parse(Console.ReadLine());

                    Console.WriteLine("Saldo por hora: ");

                    lista03[i].SaldoPorHora = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Cargo: ");

                    lista03[i].Cargo = Console.ReadLine();

                    temporaria = true;

                    break;
                }
                else
                {
                    temporaria = false;
                }
            }
            if (temporaria == false)
            {
                Console.WriteLine("Não foi possivel encontrar o cpf no sistema!");
            }

            MostrarDadosFuncionario(lista03);
        }

        //Metodo para alterar dados do fornecedor

        public void AlteraFornecedor(List<Fornecedor> lista04, string Cpf)
        {
            bool temporaria = true;

            for (int i = 0; i < lista04.Count; i++)
            {
                if (lista04[i].Cpf.CompareTo(Cpf) == 0)
                {
                    Console.WriteLine("Preencha os dados a seguir:");

                    Console.WriteLine("Nome:");

                    lista04[i].Nome = Console.ReadLine();

                    Console.WriteLine("Cnpj com pontos: ");

                    lista04[i].Cnpj = Console.In.ReadLine();

                    Console.WriteLine("Qual oipo de produto que vende:\n1 = R$ 5, 45\n2 = R$ 6, 78\n3 = R$ 1, 43\n4 = R$ 2, 68\n5 = R$ 3, 78\n6 = R$ 2, 96");

                    lista04[i].TipoProduto = int.Parse(Console.ReadLine());

                    Console.WriteLine("Saldo: ");

                    lista04[i].Saldo = double.Parse(Console.ReadLine());

                    temporaria = true;

                    break;
                }
                else
                {
                    temporaria = false;
                }
            }
            if (temporaria == false)
            {
                Console.WriteLine("Não foi possivel encontrar o cnpj no sistema");
            }

            MostrarDadosFornecedor(lista04);
        }

        //Metodos para mostrar os dados

        public void MostrarDadosClienteNormal(List<ClienteNormal> clientesNormais)
        {
            Console.WriteLine("----------Clientes Normais----------");
            foreach (var item in clientesNormais)
            {
                Console.WriteLine();

                item.MostraDados();
            }
        }
        public void MostrarDadosClienteSocio(List<ClienteSocio> clientesSocios)
        {
            Console.WriteLine("----------Clientes Socios----------");

            foreach (var item in clientesSocios)
            {
                Console.WriteLine();

                item.MostraDados();
                item.MostraAcoes();
            }
        }
        public void MostrarDadosFuncionario(List<Funcionarios> funcionarios)
        {
            Console.WriteLine("----------Funcionarios----------");
            foreach (var item in funcionarios)
            {
                Console.WriteLine();

                item.MostraDados();

                item.MostraCargo();
            }
        }
        public void MostrarDadosFornecedor(List<Fornecedor> fornecedores)
        {
            foreach (var item in fornecedores)
            {
                Console.WriteLine();

                item.MostraDados();

                Console.WriteLine();

                item.MostraQTDFornecida();
            }
        }

        //Função / Metodo para bater cartão


        public void BaterCartao2(List<Funcionarios> lista, string Cpf, int entrada)
        {
            bool temporaria = true;

            Funcionarios funcionario = new Funcionarios();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Cpf.CompareTo(Cpf) == 0)
                {
                    if (lista[i].BaterPontoMes == true)
                    {
                        Console.WriteLine("Você já bateu o ponto!");
                    }
                    else
                    {
                        if (entrada == 1)
                        {
                            lista[i].BaterPontoMes = false;

                            Console.WriteLine("hora de entrada:");

                            int hrEntrada = int.Parse(Console.ReadLine());

                            Console.WriteLine("hora de saida:");

                            int hrSaida = int.Parse(Console.ReadLine());

                            double Salario = lista[i].SaldoPorHora * funcionario.BatePonto(hrEntrada, hrSaida);

                            lista[i].Saldo = Salario;
                        }
                        else if (entrada == 2)
                        {
                            lista[i].BaterPontoMes = true;

                            double Salario = lista[i].SaldoPorHora * funcionario.DiasTrabalhados();

                            lista[i].Saldo = Salario;
                        }
                    }
                    temporaria = true;

                    break;

                }
                else
                {
                    temporaria = false;
                }
            }
            if (temporaria == false)
            {
                Console.WriteLine("Não foi possivel encontrar o cpf no sistema");
            }
        }

        //Função / Metodo para calcular o lucro final

        public void CalculandoLucro(List<ClienteNormal> cliNormais, List<ClienteSocio> cliSocios, List<Funcionarios> funcionarios, List<Fornecedor> fornecedores)
        {
            double lucro = 0;

            for (int i = 0; i < cliNormais.Count; i++)
            {
                lucro += cliNormais[i].Saldo;
            }
            for (int i = 0; i < cliSocios.Count; i++)
            {
                lucro += cliSocios[i].Saldo;
            }

            double perda = 0;

            for (int i = 0; i < funcionarios.Count; i++)
            {
                perda += funcionarios[i].Saldo;
            }
            for (int i = 0; i < fornecedores.Count; i++)
            {
                perda += fornecedores[i].Saldo;
            }

            double acoes = 0;

            for (int i = 0; i < cliSocios.Count; i++)
            {
                acoes += cliSocios[i].qtdAcoes;
            }

            acoes = acoes / 100;

            perda -= perda * acoes;

            lucro -= perda;

            double banco = 0;

            if (lucro > 0)
            {
                lucro -= lucro * acoes;
                banco = lucro;
            }
            else
            {
                Console.WriteLine("Não houve lucro, apenas prejuízo!");
            }
            
            for (int i = 0; i < cliNormais.Count; i++)
            {
                cliNormais[i].Saldo = 0;
            }
            for (int i = 0; i < cliSocios.Count; i++)
            {
                cliSocios[i].Saldo = 0;
            }
            for (int i = 0; i < funcionarios.Count; i++)
            {
                funcionarios[i].Saldo = 0;
            }

            Console.WriteLine();
            Console.WriteLine("Lucro: {0:C}", banco);
            Console.WriteLine();
            
            
            DefinirQuantidadeFornecida(fornecedores);

            MostrarDadosFornecedor(fornecedores);
            Console.WriteLine();
            
            Console.WriteLine();
            

            Console.ReadLine();
        }
    }
}


    

    

