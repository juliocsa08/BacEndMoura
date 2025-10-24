 int senhaValida = 1234;

   
        Console.Write("Digite a senha: ");
        int senha = int.Parse(Console.ReadLine());


        if (senha == senhaValida)
        {
            Console.WriteLine("ACESSO PERMITIDO");
        }
        else
        {
            Console.WriteLine("ACESSO NEGADO");
        }