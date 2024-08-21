using FundamentalsOO;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
           Book book1 = new Book();
           book1.Title = "Vimos e Ouvimos";
           book1.Author = "Israel Subirá";
           book1.Publisher = "Editora Vida e Orvaho";
           book1.ReleaseYear = 2023;

           Book book2 = new Book();
           book2.Title = "O Deus que destrói sonhos";
           book2.Author = "Rodrigo Bibo";
           book2.Publisher = "Thomas Nelson Brasil";
           book2.ReleaseYear = 2021;

           Book book3 = new Book();
           book3.Title = "Cristianismo Puro e Simples";
           book3.Author = "C.S Lewis";
           book3.Publisher = "Thomas Nelson Brasil";
           book3.ReleaseYear = 2017;
        */
        // ---

        Student student1 = new Student();
        student1.Name = "Maysa Silva Rondon";
        student1.Id = 4455;
        student1.Email = "maysa.rondon@aluno.senai.br";
        student1.Birthdate = new DateOnly(2008, 06, 07);

        Student student2 = new Student();
        student2.Name = "Juliana Maria Fulanetto";
        student2.Id = 7650;
        student2.Email = "juliana.fulanetto@aluno.senai.br";
        student2.Birthdate = new DateOnly(2008, 01, 15);

        Student student3 = new Student();
        student3.Name = "Cristiano de Paula";
        student3.Id = 2390;
        student3.Email = "cristiano.paula@sp.senai.br";
        student3.Birthdate = new DateOnly(1981, 07, 16);

        // imprimir na tela
        Console.WriteLine("Aluno 1");
        Console.WriteLine("Nome:" + student1.Name);
        Console.WriteLine("RM:" + student1.Id);
        Console.WriteLine("E-mail:" + student1.Email);
        Console.WriteLine("Nascimento" + student1.Birthdate);
        Console.WriteLine("-----------------------------------------");

        Console.WriteLine("Aluno 2");
        Console.WriteLine("Nome:" + student2.Name);
        Console.WriteLine("RM:" + student2.Id);
        Console.WriteLine("E-mail:" + student2.Email);
        Console.WriteLine("Nascimento" + student2.Birthdate);
        Console.WriteLine("-----------------------------------------");

        Console.WriteLine("Aluno 3");
        Console.WriteLine("Nome:" + student3.Name);
        Console.WriteLine("RM:" + student3.Id);
        Console.WriteLine("E-mail:" + student3.Email);
        Console.WriteLine("Nascimento" + student3.Birthdate);
        Console.WriteLine("-----------------------------------------");

        //Instanciar Objeto de Tipo Produto
        Product p1 = new Product();
        p1.Code = 7891098042149;
        p1.Name = "Ice Tea Leão - sabor Pêssego | zero | 300ml";
        p1.Price = 1.99;
        p1.Stock = 45;

        //Chamar qunatidade em estoque
        p1.Amount();
        Console.WriteLine("-----------------------------------------");

        // Instanciar um Objeto do Tipo Carro
        Car car1 = new Car();

        car1.Brand = "BYD";
        car1.Model = "Mini Dolphin";
        car1.Speed = 80;

        car1.SpeedUp(5);
        car1.SlowDown(100);
        Console.WriteLine("-----------------------------------------");

        // Tipo Pessoa
        Person person1 = new Person();

        person1.Name = "Maria";
        person1.Age = 29;

        person1.GetOlder(1);
        Console.WriteLine("-----------------------------------------");

        // Tipo Funcionário - Herdando de Person
        Employee employee1 = new Employee();

        employee1.Name = "João";
        employee1.Age = 34;
        employee1.Position = "Arqueólogo";
        employee1.Wage = 7580.97;

        //employee1.
        employee1.Presentation();
        Console.WriteLine("-----------------------------------------");

        /*
                //Inserindo objeto
                Animal animal1 = new Animal();

                //Inserindo dados no atributo
                animal1.Especie = "cachorro";

                //Chamando o metodo do objeto
                animal1.emitirSom();

                //Imprimindo a informação na tela
                Console.WriteLine("O animal " + animal1.Especie + " emitiu um som.");
                */

        Cat cat1 = new Cat();
        cat1.Name = "Cato";
        Console.WriteLine(cat1.Name + " faz: ");
        cat1.MakeSound();

        Console.WriteLine("========================");
        Console.WriteLine();

        Pig pig1 = new Pig();
        pig1.Name = "Piggo";
        Console.WriteLine(pig1.Name + " faz: ");
        pig1.MakeSound();


        Console.WriteLine("========================");
        Console.WriteLine();

        Chicken chicken1 = new Chicken();
        chicken1.Name = "Chicko";
        Console.WriteLine(chicken1.Name + " faz: ");
        chicken1.MakeSound();

        /*Console.WriteLine("========================");
        Console.WriteLine();

        Cavalheiro macedo = new Cavalheiro();
        macedo.Nome = "Macedo";
        macedo.Vida = 100;
        macedo.Inteligencia = 70;
        macedo.Agilidade = 65;
        macedo.Forca = 80;
        macedo.Nivel = 1; */

        Console.WriteLine("========================");
        Console.WriteLine();

        Wizard lucca = new Wizard();
        lucca.Name = "Lucca";
        lucca.Life = 100;
        lucca.Intelligence = 85;
        lucca.Agility = 50;
        lucca.Strength = 60;
        lucca.Level = 1;


        Elf choquito = new Elf();
        choquito.Name = "Choquito";
        choquito.Life = 100;
        choquito.Intelligence = 55;
        choquito.Agility = 90;
        choquito.Strength = 75;
        choquito.Level = 1;

        lucca.Presentation();
        choquito.Presentation();
        lucca.Battle(choquito);


    }
}
