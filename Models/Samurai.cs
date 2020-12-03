using System;
namespace WizNinjaSam.Models
{
    public class Samurai : Human
    {

        public Samurai(string Name) : base(Name)
        {
            base.Health = 200;
        }

        public override int Attack(Human target)
        {
            if (Health <= 50)
            {
                target.Health = 0;
            }
            else
            {
                Console.WriteLine($"{Name} is not weak enough to release his hidden talent.");
            }
            return target.Health;
        }

        public void Meditate()
        {
            Health = 200;
            Console.WriteLine($"{Name} meditated and healed to full health.");
        }
    }
}