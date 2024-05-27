var livros = new List<string>();

while (true)
{
    Console.WriteLine("---- MENU PRINCIPAL ----\n");
    Console.WriteLine("1 - Cadastrar livro");
    Console.WriteLine("2 - Listar livros");
    Console.WriteLine("3 - Remover livro");
    Console.WriteLine("0 - Sair");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("\nDigite o titulo do livro\n");

            var nomeLivro = Console.ReadLine();

            livros.Add(nomeLivro);

            Console.WriteLine("\nLivro cadastrado\n");

            break;
        case "2":
            Console.WriteLine();
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }
            Console.WriteLine();

            break;
        case "3":
            Console.WriteLine("\nDigite o nome do livro\n");

            var livroRemover = Console.ReadLine();

            var sucesso = livros.Remove(livroRemover);

            if (sucesso)
            {
                Console.WriteLine("\nLivro removido\n");
            }
            else
            {
                Console.WriteLine("\nLivro nao encontrado\n");
            }

            break;
        case "0":
            Console.WriteLine("\nEncerrando a aplicação");

            return;
        default:
            Console.WriteLine("\nOpção invalida\n");

            break;
    }
}