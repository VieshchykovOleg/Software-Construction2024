using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Hero warrior = new Warrior();
        warrior = new Armor(warrior);
        warrior = new Sword(warrior);

        Hero mage = new Mage();
        mage = new Sword(mage);
        Hero paladin = new Paladin();

        Console.WriteLine("Warrior: " + warrior.GetDescription());
        Console.WriteLine("Attack: " + warrior.GetAttack());
        Console.WriteLine("Defense: " + warrior.GetDefense());
        Console.WriteLine("Health: " + warrior.GetHealth());

        Console.WriteLine("\nMage: " + mage.GetDescription());
        Console.WriteLine("Attack: " + mage.GetAttack());
        Console.WriteLine("Defense: " + mage.GetDefense());
        Console.WriteLine("Health: " + mage.GetHealth());

        Console.WriteLine("\nPaladin: " + paladin.GetDescription());
        Console.WriteLine("Attack: " + paladin.GetAttack());
        Console.WriteLine("Defense: " + paladin.GetDefense());
        Console.WriteLine("Health: " + paladin.GetHealth());
    }
}
