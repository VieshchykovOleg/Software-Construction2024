using System;
using System.Collections.Generic;
using System.Data;

namespace Zoo
{
    public interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        string Diet { get; set; }
    }

    public interface IEmployee
    {
        string Name { get; set; }
        string Position { get; set; }
    }

    public interface IFood
    {
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {   
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                List<IAnimal> animals = new List<IAnimal>
                {
                    new Animal { Name = "Лев", Age = 8, Diet = "М'ясо" },
                    new Animal { Name = "Слон", Age = 6, Diet = "Листя" },
                    new Animal { Name = "Койот", Age = 4, Diet = "М'ясо" },
                    new Animal { Name = "Мавпа", Age = 10, Diet = "Листя" }
                };

                List<IEmployee> employees = new List<IEmployee>
                {
                    new Employee { Name = "Іван", Position = "Доглядач" },
                    new Employee { Name = "Марія", Position = "Ветеринар" },
                    new Employee { Name = "Коля", Position = "Прибиральник" },
                };

                List<IFood> foods = new List<IFood>
                {
                    new Food { Name = "М'ясо" },
                    new Food { Name = "Листя" },
                };

                ZooInventory inventory = new ZooInventory(animals, employees, foods);
                inventory.DisplayFoodAnimalEats();
                inventory.DisplayAnimalList();
                var newAnimal = new Animal { Name = "Рись", Age = 8, Diet = "М'ясо" };
                inventory.AddAnimal(newAnimal);
                var foundAnimal = inventory.FindAnimalByName("Леhhв");
                if (foundAnimal != null)
                {
                    Console.WriteLine($"Знайдено тварину: {foundAnimal.Name}");
                }
                else
                {
                    Console.WriteLine("не знайдено");
                }
                // Оновлення інформації про тварину
                var oldAnimal = animals[0];
                var updatedAnimal = new Animal { Name = "Тигр", Age = 9, Diet = "М'ясо" };
                inventory.UpdateAnimal(oldAnimal, updatedAnimal);
                Console.WriteLine("Оновлений список тварин");
                inventory.DisplayAnimalList();
                inventory.RemoveAnimal(newAnimal);

                var newFood = new Food { Name = "Риба" };
                inventory.AddFood(newFood);
                inventory.DisplayFoodList();
                inventory.RemoveFood(newFood);
                Console.WriteLine();
                // Виведення загальної інформації про зоопарк
                inventory.DisplayZooInfo();
        }
    }
}
