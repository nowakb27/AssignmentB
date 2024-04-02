using System;
using System.Collections;

namespace MobileAppModule1
{
    public class CreateAnimal
    {
        private ArrayList zoo;

        public CreateAnimal(ArrayList zoo)
        {
            this.zoo = zoo;
        }

        public void CreateNewAnimal()
        {
            Console.WriteLine("What type of animal do you want to create?");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
            {
                Console.WriteLine("Invalid choice. Please enter 1 for Dog or 2 for Cat.");
                return;
            }

            switch (choice)
            {
                case 1:
                    CreateDog();
                    break;
                case 2:
                    CreateCat();
                    break;
            }
        }

        private void CreateDog()
        {
            Console.WriteLine("Enter the name of the dog:");
            string name = Console.ReadLine();

            Console.WriteLine("Is the dog friendly? (true/false):");
            if (!bool.TryParse(Console.ReadLine(), out bool friendly))
            {
                Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
                return;
            }

            zoo.Add(new Dog(friendly, name));
            Console.WriteLine("Dog successfully added to zoo.");
        }

        private void CreateCat()
        {
            Console.WriteLine("Enter the name of the cat:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the number of mouses killed:");
            if (!int.TryParse(Console.ReadLine(), out int mousesKilled))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            zoo.Add(new Cat(mousesKilled, name));
            Console.WriteLine("Cat successfully added to zoo.");
        }
    }
}
