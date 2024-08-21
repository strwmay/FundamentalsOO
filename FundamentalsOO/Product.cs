namespace FundamentalsOO
{
    public class Product
    {
        // Atributos
        public long Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        // Métodos
        public void Amount()
        {
            Console.WriteLine("A quantidade em estoque é de " + this.Stock + " produtos.");
        }
    }
}
