using P1Q3;

internal class Program
{
    private static void Main()
    {
        int aux = 1;
        int contCarro = 0;
        int contCliente = 0;
        int contEmprest = 0;

        Carro[] carros = new Carro[100];
        Cliente[] clientes = new Cliente[100];
        Emprestimo[] emprestimos = new Emprestimo[100];

        while (aux != 0)
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção do menu :\n");
            Console.WriteLine(" [1] - Cadastrar um carro");
            Console.WriteLine(" [2] - Cadastrar um cliente");
            Console.WriteLine(" [3] - Associar um emprestimo");
            Console.WriteLine(" [4] - Imprimir relatório");
            Console.WriteLine(" [5] - Sair");

            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    //Cadastrar carro
                    Console.Clear();
                    Carro c = new Carro();

                    Console.WriteLine("Digite a categoria: ");
                    c.Categoria = Console.ReadLine();

                    Console.WriteLine("Digite a marca da empresa: ");
                    c.MarcaEmpresa = Console.ReadLine();

                    Console.WriteLine("Digite o modelo: ");
                    c.Modelo = Console.ReadLine();

                    Console.WriteLine("Digite o ano: ");
                    c.Ano = Convert.ToInt32(Console.ReadLine());

                    carros[contCarro] = c;
                    contCarro++;

                    break;

                case "2":
                    //Cadastrar cliente
                    Console.Clear();
                    Cliente cliente = new Cliente();

                    Console.WriteLine("Digite o nome: ");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o endereço: ");
                    cliente.Endereço = Console.ReadLine();

                    Console.WriteLine("Digite o telefone: ");
                    cliente.Telefone = Console.ReadLine();

                    clientes[contCliente] = cliente;
                    contCliente++;

                    break;

                case "3":
                    //Cadastrar empréstimo
                    Console.Clear();
                    Emprestimo emprest = new Emprestimo();

                    Console.WriteLine("Digite o nome do cliente: ");
                    emprest.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o modelo do carro emprestado: ");
                    emprest.CarroEmprest.Modelo = Console.ReadLine();

                    Console.WriteLine("Digite o preço por dia: ");
                    emprest.PreçoDia = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite a quantidade de dias: ");
                    emprest.Dias = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o preço final: ");
                    emprest.PreçoFinal = Convert.ToDouble(Console.ReadLine());

                    for (int i = 0; i <= contCarro; i++)
                    {
                        if(emprest.CarroEmprest.Modelo == carros[i].Modelo)
                        { 
                            emprest.CarroEmprest = carros[i];
                        }
                    }

                    emprestimos[contEmprest] = emprest;
                    contEmprest++;

                    break;

                case "4":
                    //Relatório de empréstimos
                    Console.Clear();
                    for (int e = 0; e <= contEmprest; e++)
                    {
                        Console.WriteLine("Emprestimo N°" + (e + 1));
                        emprestimos[e].ImprimeRelatorio();
                    }
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Favor selecionar uma das opções mostradas no menu");
                    Console.ReadLine();
                    break;
            }
        }
    }
}