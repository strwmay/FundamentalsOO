namespace FundamentalsOO
{
    public class Character
    {
        //atributos
        public string Name { get; set; }
        //public string Categoria { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Life { get; set; }

        //metodos
        public virtual void Presentation() { }
        public virtual void Upgrade()
        {

            this.Level += 2;
            this.Strength *= 2;
            this.Intelligence *= 2;
            this.Agility *= 2;
            Console.WriteLine("O jogador " + this.Name + " evoluiu para o nível "
                + this.Level + ". Seus novos valores são: \nAgilidade : " + this.Agility
             + "\nInteligência: " + this.Intelligence + "\nForça: " + this.Strength);
        }

        public virtual int Attack()
        {
            int AttackPoints = 0;
            AttackPoints = (this.Intelligence + (this.Strength * 2) + this.Agility + this.Level
                + this.Life) / 6;
            return AttackPoints;
        }
        public virtual int Defend()
        {
            int DefensePoints = 0;
            DefensePoints = (this.Intelligence + this.Strength + (this.Agility * 2) + this.Level
                + this.Life) / 6;
            return DefensePoints;
        }
        public virtual void Battle(Character p)
        {
            bool Winner = false;
            while (Winner == false)
            {
                int AttackValue = this.Attack();
                int EnemyDefenseValue = p.Defend();
                int LifeDamage = AttackValue - EnemyDefenseValue;
                if (LifeDamage <= 0)
                {
                    LifeDamage = 1;
                }

                p.Life = p.Life - LifeDamage;
                Console.WriteLine("Dano na vida do inimigo em " + LifeDamage);
                Console.WriteLine("O nível de vida do inimigo agora é " + p.Life);

                int AttackValueInimigo = p.Attack();
                int DefenseValue = this.Defend();
                int LifeDamage2 = AttackValueInimigo - DefenseValue;
                if (LifeDamage2 <= 0)
                {
                    LifeDamage = 1;
                }
                this.Life = this.Life - LifeDamage2;
                Console.WriteLine("Dano na vida do atacante em " + LifeDamage2);
                Console.WriteLine("O nível de vida do atacante é " + this.Life);

                Console.WriteLine("========================");

                if (this.Life <= 0)
                {
                    Console.WriteLine("O personagem " + p.Name + " venceu!");
                    Winner = true;
                    p.Upgrade();
                }
                if (p.Life <= 0)
                {
                    Console.WriteLine("O personagem " + this.Name + " venceu!");
                    Winner = true;
                    this.Upgrade();
                }
            }
        }
    }
}
