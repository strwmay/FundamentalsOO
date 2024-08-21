namespace FundamentalsOO
{
    internal class Knight : Character
    {
        public override void Presentation()
        {
            Console.WriteLine("Prazer, seria um honra trabalhar ao seu lado nessa luta, sou conhecido como "
                            + this.Name + " tenho " + this.Life + " pontos de vida. Inteligência: "
                            + this.Intelligence + "\nAgilidade: " + this.Agility + "\nForca: " + this.Strength
                            + "\nMeu nível atual é: " + this.Level);
            Console.WriteLine("========================");
        }
    }
}
