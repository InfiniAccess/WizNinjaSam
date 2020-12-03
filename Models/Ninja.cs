using System;
namespace WizNinjaSam.Models
{
    public class Ninja : Human
    {
        public Ninja(string Name) : base(Name)
        {
            base.Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            Random rand = new Random();
            bool bonus = false;
            int dmg = 5 * Dexterity;
            int num = rand.Next(1, 11);
            if (num == 1 || num == 2)
            {
                bonus = true;
                dmg += 10;
            }
            target.Health -= dmg;
            if (bonus == true)
            {
                Console.WriteLine($"{Name} attacked {target.Name} with precision and dealt {dmg} damage.");
            }
            else
            {
                Console.WriteLine($"{Name} attacked {target.Name} and dealt {dmg} damage.");
            }
            return target.Health;
        }

        public void Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
            Console.WriteLine($"{Name} steals 5 health from {target.Name}.");
        }
    }
}