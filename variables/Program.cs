using System;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogsNames= "Mercury";
            int dogsAge = 5;
            char grade= 'A';
            bool dogGender = true;
            decimal worldPopulation = 6000000000m;
            Console.WriteLine($"I have a dog named {dogsNames}.");
            Console.WriteLine($" She is {dogsAge} years old.");
            Console.WriteLine($"She would get an {grade} in doggy daycare.");
            Console.WriteLine($"Yes, it is {dogGender} she is female. She is one of {worldPopulation} in the dog population but she is very special!");       
        }
    }
}
