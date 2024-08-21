namespace FundamentalsOO
{
    public class Wizard : Character
    {
        public override void Presentation()
        {
            Console.WriteLine("Olá, sou o mago mais poderoso das terras, conhecido como "
                + this.Name + " tenho " + this.Life + " pontos de vida. \nInteligência: "
                + this.Intelligence + "\nAgilidade: " + this.Agility + "\nForca: " + this.Strength
                + ". \nMeu nível atual é: " + this.Level);
            Console.WriteLine("========================");
        }
    }
}
}
