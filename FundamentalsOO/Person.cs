namespace FundamentalsOO
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetOlder(int years)
        {
            this.Age += years;
            Console.WriteLine("Agora você tem " + this.Age + " anos.");
        }

    }
}
