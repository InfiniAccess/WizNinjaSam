using System;
using WizNinjaSam.Models;

namespace WizNinjaSam
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Sebastian = new Wizard("Sebastian");
            Samurai Steve = new Samurai("Steve");
            Ninja Dave = new Ninja("Dave");

            Steve.Attack(Sebastian);
            Sebastian.Attack(Steve);
            Dave.Attack(Sebastian);

        }
    }
}
