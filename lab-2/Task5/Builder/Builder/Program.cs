using System;

class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();

        HeroBuilder heroBuilder = new HeroBuilder();
        director.Construct(heroBuilder);
        Character hero = heroBuilder.Build();

        EnemyBuilder enemyBuilder = new EnemyBuilder();
        director.Construct(enemyBuilder);
        Character enemy = enemyBuilder.SetClothing("Чорна роба") 
                                       .SetInventory("Магічна куля")
                                       .Build();

        Console.WriteLine("Герой:");
        hero.DisplayInfo();

        Console.WriteLine("\nВорог:");
        enemy.DisplayInfo();
    }
}
