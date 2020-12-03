using System;
namespace WizNinjaSam.Models
{
    public class Wizard : Human
    {
        public Wizard(string Name) : base(Name)
        {
            base.Intelligence = 50;
            base.Health = 50;
        }

        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            Health += dmg;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} and dealt {dmg} damage.");
            Console.WriteLine($"{Name} healed {dmg} health.");
            return target.Health;
        }

        public void Heal(Human target)
        {
            int hpHeal = Intelligence * 10;
            target.Health += hpHeal;
            Console.WriteLine($"{Name} heals {target.Health} by {hpHeal}.");
        }

    }
}