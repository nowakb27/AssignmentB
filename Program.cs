using System;
using System.Collections;
using System.Collections.Generic;

namespace MobileAppModule1
{
    class Program
    {
        private static FileOutput outFile = new FileOutput("animals.txt");
        private static FileInput inFile = new FileInput("animals.txt");

        public static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList();

            // Lines to Replace Begin Here
    
            CreateAnimal createAnimal = new CreateAnimal(zoo);

            createAnimal.CreateNewAnimal();

            // End Lines to Replace

            foreach (ITalkable thing in zoo)
            {
                PrintOut(thing);
            }
            outFile.FileClose();
            inFile.FileRead();
            inFile.FileClose();

            FileInput indata = new FileInput("animals.txt");
            string line;
            while ((line = indata.FileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public static void PrintOut(ITalkable p)
        {
            Console.WriteLine(p.GetName() + " says=" + p.Talk());
            outFile.FileWrite(p.GetName() + " | " + p.Talk());
        }
    }
}