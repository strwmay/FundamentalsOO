namespace FundamentalsOO
{
    public class Employee : Person // um funcionário também é uma pessoa, logo podemos fazer com que ele herde os atributos da class Person
    {
        public string Position { get; set; }
        public double Wage { get; set; }

        public void Presentation()
        {
            Console.WriteLine("Prazer, sou o " + this.Name + ", tenho " + this.Age + "anos de idade e trabalho como" + this.Position + "o que me gera uma renda mensal de R$ " + this.Wage + ".");
        }
    }
}
