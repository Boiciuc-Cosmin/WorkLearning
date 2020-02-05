using System;
using System.Collections.Generic;

namespace FirstCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallestNumbers();
        }
        static void NumbersInTheList()
        {
            var numbers = new List<int>();
            Console.WriteLine("Enter 5 numbers that are not in the list: ");
            while (numbers.Count < 5)
            {
                var number = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    Console.WriteLine("Enter another number, this number is in the list");
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();
            foreach (var nr in numbers)
            {
                Console.Write(nr + " ");
            }
        }
        static void LikeExample()
        {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Type a name or hit enter on blank to quit");
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    break;
                }
                names.Add(input);
            }
            if (names.Count > 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]} like your post");
            }
            else if (names.Count == 1)
            {
                Console.WriteLine($"{names[0]} like your post");
            }
            else
            {
                Console.WriteLine();
            }
        }
        static void SmallestNumbers()
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
        static void ReverseName()
        {
            Console.Write("Type your name: ");
            string input = Console.ReadLine();

            var array = new char[input.Length];

            for (var i = input.Length; i > 0; i--)
            {
                array[input.Length - i] = input[i - 1];
            }
            var reversed = new string(array);
            Console.WriteLine(reversed);
        }
    }
}
