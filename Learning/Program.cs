using System;
using System.Collections.Generic;
using Learning.Math;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            string[] elements;
            Console.WriteLine("Enter numbers separated by comma");
            while (true)
            {
                var input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid List. Retry");
            }

            foreach (var number in elements)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var smallestNumber = new List<int>();
            while (smallestNumber.Count < 3)
            {
                var minNumber = numbers[0];

                foreach (var number in numbers)
                {
                    if (number < minNumber)
                    {
                        minNumber = number;
                    }
                }
                smallestNumber.Add(minNumber);

                numbers.Remove(minNumber);
            }
            
            Console.Write("The 3 small number are: ");
            foreach (var numb in smallestNumber)
            {
                Console.Write(numb);
            }
        }
    }
}

   