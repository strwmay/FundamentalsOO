namespace FundamentalsOO
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public void SpeedUp(int Km)
        {
            this.Speed += Km;
            Console.WriteLine("Velocidade atual: " + this.Speed + "km/h.");
        }

        public void SlowDown(int Km)
        {
            if (this.Speed > 0)
            {
                Console.WriteLine("O carro parou.");
            }
            else
            {
                this.Speed -= Km;
                Console.WriteLine("Velocidade atual: " + this.Speed + "km/h.");
            }
        }
    }
}
