
using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace Desafio13
{
    class Program
    {
        class Client
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }


            public override string ToString()
            {
                return Name + ", R$:" + Salary.ToString("f2", CultureInfo.InvariantCulture);
            }



            static void Main(string[] args)
            {

                List<Client> clients = new List<Client>();

                clients.Add(new Client() { Name = "João", Salary = 500000.00m });
                clients.Add(new Client() { Name = "Maria", Salary = 6000.00m });
                clients.Add(new Client() { Name = "Antonio", Salary = 9000.00m });
                clients.Add(new Client() { Name = "Carlos", Salary = 1000.00m });
                clients.Add(new Client() { Name = "Bruno", Salary = 6000.00m });
                clients.Add(new Client() { Name = "Amanda", Salary = 10000.00m });

                void ListaCompleta()
                {

                    var listacompleta =
                        from client in clients
                        orderby client.Name ascending
                        select client;

                    foreach (var item in listacompleta)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para voltar ao menu");
                    Console.ReadKey();

                    
                }

                void ListaTresMaioresSalarios()
                {
                    var key = 3;

                    var tresMaiorSalario = clients.OrderByDescending(x => x.Salary).Take(key).OrderBy(x => x.Name);
                    foreach (var item in tresMaiorSalario)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para voltar ao menu");
                    Console.ReadKey();
                }


                bool menu = false;
                do
                {
                    Console.WriteLine("Lista de Clientes: ");
                    Console.WriteLine("[1]-Ver A lista de Clientes Completa");
                    Console.WriteLine("[2]-Ver a lista com os 3  Clientes com maior Salário");
                    Console.WriteLine("[3]-Sair");
                    int escolha = int.Parse(Console.ReadLine());
                    switch (escolha)
                    {
                        case 1:
                            ListaCompleta();
                            break;
                        case 2:
                            ListaTresMaioresSalarios();
                            
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                    }
                    Console.Clear();

                } while (menu == false);


                


            }
        }
    }
}
