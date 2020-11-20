using System;
using System.IO;

namespace IndependentWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What file would you like to move to the 'fruit' folder?");
            string userInput = Console.ReadLine();
            FruitsSort(userInput);
            Console.WriteLine("What file would you like to move to the 'vegetable' folder?");
            string userInput2 = Console.ReadLine();
            VegetablesSort(userInput2);

            DeleteAllFiles();
            DeleteAllFiles2();


        }

        public static void FruitsSort(string fileName)
        {
            string sourceDirectory = @"C:\Users\opilane\samples\fruitsnvegs";
            string destinationPath = @"C:\Users\opilane\samples\fruitsnvegs\fruit";
            File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));
        }

        public static void VegetablesSort(string fileName)
        {
            string sourceDirectory = @"C:\Users\opilane\samples\fruitsnvegs";
            string destinationPath = @"C:\Users\opilane\samples\fruitsnvegs\vegetables";
            File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));
        }

        public static void DeleteAllFiles()
        {
            string rootpath = @"C:\Users\opilane\samples\fruitsnvegs\fruit";
            string fileName = "toiletPaper.txt";

            if(File.Exists(Path.Combine(rootpath, fileName)))
            {
                File.Delete(Path.Combine(rootpath, fileName));
                Console.WriteLine("File deleted.");
            }else
            {
                Console.WriteLine("File not found.");
            }

        }

        public static void DeleteAllFiles2()
        {
            string rootpath = @"C:\Users\opilane\samples\fruitsnvegs\vegetables";
            string fileName = "cheese.txt";

            if (File.Exists(Path.Combine(rootpath, fileName)))
            {
                File.Delete(Path.Combine(rootpath, fileName));
                Console.WriteLine("File deleted.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }

        }

    }
}
