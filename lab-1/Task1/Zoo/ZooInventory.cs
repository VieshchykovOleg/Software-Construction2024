using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
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
        public void DisplayFoodList()
        {
            Console.WriteLine("Список їжі:");
            foreach (var food in foods)
            {
                Console.WriteLine($"Їжа: {food.Name}");
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

        public void AddAnimal(IAnimal animal)
        {
            animals.Add(animal);
        }

        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }

        public void AddFood(IFood food)
        {
            foods.Add(food);
        }

        public IAnimal FindAnimalByName(string name)
        {
            return animals.Find(animal => animal.Name == name);
        }

        public void RemoveAnimal(IAnimal animal)
        {
            animals.Remove(animal);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            employees.Remove(employee);
        }

        public void RemoveFood(IFood food)
        {
            foods.Remove(food);
        }

        public void DisplayZooInfo()
        {
            Console.WriteLine($"Кількість тварин: {animals.Count}");
            Console.WriteLine($"Кількість співробітників: {employees.Count}");
            Console.WriteLine($"Кількість видів харчів: {foods.Count}");
        }

        public void UpdateAnimal(IAnimal oldAnimal, IAnimal newAnimal)
        {
            int index = animals.IndexOf(oldAnimal);
            if (index != -1)
            {
                animals[index] = newAnimal;
            }
        }

        public void UpdateEmployee(IEmployee oldEmployee, IEmployee newEmployee)
        {
            int index = employees.IndexOf(oldEmployee);
            if (index != -1)
            {
                employees[index] = newEmployee;
            }
        }

        public void UpdateFood(IFood oldFood, IFood newFood)
        {
            int index = foods.IndexOf(oldFood);
            if (index != -1)
            {
                foods[index] = newFood;
            }
        }
    }
}