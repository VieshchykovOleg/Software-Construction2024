using System;
using System.Collections.Generic;

namespace Zoo
{
    interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        string Diet { get; set; }
    }

    interface IEmployee
    {
        string Name { get; set; }
        string Position { get; set; }
    }
    interface IFood
    {
        public string Name { get; set; }
    }
    class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Diet { get; set; }
    }

    class Enclosure
    {
        public string Type { get; set; }
        public double Area { get; set; }
    }

    class Food : IFood
    {
        public string Name { get; set; }
    }

    class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }
    }

    class ZooInventory
    {
        private List<IAnimal> animals;
        private List<IEmployee> employees;
        private List<IFood> foods;

        public ZooInventory(List<IAnimal> animals, List<IEmployee> employees, List<IFood> foods)
        {
            this.animals = animals;
            this.employees = employees;
            this.foods = foods;
        }
        public void DisplayAnimalList()
        {
            Console.WriteLine("Список тварин:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"Тварина: {animal.Name}, Тип харчування: {animal.Diet}, Вік особи: {animal.Age}");
            }
        }

        public void DisplayEmployeeCount()
        {
            Console.WriteLine($"Кількість співробітників: {employees.Count}\n");
        }
        public void DisplayFoodAnimalEats()
        {
            foreach (var animal in animals)
            {
                var food = foods.Find(f => f.Name == animal.Diet);
                if (food != null)
                {
                    Console.WriteLine($"{animal.Name} полюбляє їсти {food.Name}");
                }
                else
                {
                    Console.WriteLine($"{animal.Name} не можна визначити");
                }
            }
        }
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
            inventory.DisplayAnimalList();
            inventory.DisplayEmployeeCount();
            inventory.DisplayFoodAnimalEats();
        }
    }
}
