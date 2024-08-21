namespace FundamentalsOO
{
    public class Elf : Character
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Halora, adoro pregar peças e ser vitorioso sempre, sou conhecido como "
                + this.Name + " tenho " + this.Life + " pontos de vida. \nInteligência: "
                + this.Intelligence + "\nAgilidade: " + this.Agility + "\nForca: " + this.Strength
                + "\nMeu nível atual é: " + this.Level);
            Console.WriteLine("========================");
        }
    }
}

