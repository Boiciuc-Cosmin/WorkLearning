using System;
using System.Collections.Generic;
using System.Text;

namespace LearningLibrary
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number; 
            }
            return sum;
        }
    }
}
