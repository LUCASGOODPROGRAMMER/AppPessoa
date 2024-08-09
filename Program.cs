using AppPessoa.RegrasDeNegocio;

int opcao = 0;

/*é um repositório/criar listar de inteiros, doubles bla bla.../não existe por si só
 tem de ser declarado que tipo de lista ele vai ser "List <int> X = new.List <int>();"
bla bla.../ Trabalhar c// List "List<Pessoa> pessoas = new List<Pessoas>();
no List eu não preciso definir limite como no for(int i = bla bla)"

método List: pessoas.Add(pessoa)"estou adicionando pessoa à lista";*/


List<Pessoa> listaPessoa = new List<Pessoa>();

//função cadastrar

void CadastrarPessoa()
{
    int opc = 1;
    while (opc!=0)
    {
        Console.Clear();//limpar tela
        Console.WriteLine("$$$$$$$$$$$$$$$ CADASTRAR PESSOA $$$$$$$$$$$$$$$\n");

        Pessoa pessoa = new Pessoa();
        pessoa.Id = listaPessoa.Count + 1;

        Console.WriteLine("ID--"+pessoa.Id);

        Console.Write("Informe seu nome--");
        pessoa.Nome = Console.ReadLine();

        Console.Write("Informe seu CPF--");
        pessoa.Cpf = Console.ReadLine();

        Console.Write("Informe seu Rg--");
        pessoa.Rg = Console.ReadLine();

        Console.Write("Informe seu Salário--");
        pessoa.Salario = Convert.ToDouble(Console.ReadLine());

        //com o objeto preenchido podemos inserir na lista

        listaPessoa.Add(pessoa);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("CADASTRO REALIZADO (@-@)");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Desejar continuar Cadastrando? (N/S)....");
        string resposta = Console.ReadLine();

        if (resposta.ToUpper() == "N") opc = 0;
        

        


    }//fim do while
}//fim da função cadastrar

//função Listar Pessoa

void ListarPessoas()
{
    foreach (var pessoa in listaPessoa)
    {
        Console.WriteLine("Id--" + pessoa.Id);
        Console.WriteLine("Nome--" + pessoa.Nome);
        Console.WriteLine("Cpf--" + pessoa.Rg);
        Console.WriteLine("Rg--" + pessoa.Rg);
        Console.WriteLine("Salário--" + pessoa.Salario.ToString("C2"));
       
    }

    Console.ReadKey();
}//fim da função

void ConsultarPorNome()
{
    Console.Clear();
    Console.Write("Informe o nome da pessoa--");
    string posicaoNome = Console.ReadLine();
    foreach (var pessoa in listaPessoa)
    {
        Console.Clear();
       if (pessoa.Nome.ToUpper() == posicaoNome.ToUpper())
        {
            Console.WriteLine("Id--" + pessoa.Id);
            Console.WriteLine("Nome--" + pessoa.Nome);
            Console.WriteLine("Cpf--" + pessoa.Rg);
            Console.WriteLine("Rg--" + pessoa.Rg);
            Console.WriteLine("Salário--" + pessoa.Salario.ToString("C2"));
        }//fim do if
        

    }//fim do foreach
    Console.ReadKey();
}//fim da função



while (opcao != 6)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();
    Console.WriteLine("@@@@@@@@@@@@@@@@@@@ MENU @@@@@@@@@@@@@@@@@@@");
    Console.WriteLine();
    Console.WriteLine("1 - Cadastrar Pessoas");
    Console.WriteLine("2 - Listar Pessoas");
    Console.WriteLine("3 - Consultar Pessoa por Nome");
    Console.WriteLine("4 - Consultar Pessoa por Cpf");
    Console.WriteLine("5 - Filtrar Pessoas por Salário");
    Console.WriteLine("6 - Fechar o sistema");
    Console.Write("Opção N°...........................................: ");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {

        case 1:
            {
                CadastrarPessoa();
                break;
            }//fim do case 1
        case 2:
            {
                ListarPessoas();
                break;
            }//fim do case 2
        case 3:
            {
                ConsultarPorNome();
                break;
            }//fim do case 3
        case 4:
            {

                break;
            }//fim do case 4
        case 5:
            {

                break;
            }//fim do case 5
        case 6:
            {
                Console.Clear();
                Console.WriteLine("Deseja mesmo fechar o Sistema? 1 - S/N");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper() == "N") opcao = 0;



                break;
            }//fim do case 6

        default:
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Opção inválida!!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                break;
            }//fim do default


    }//fim do 17
}