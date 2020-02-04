using System;
using System.Collections.Generic;
using System.Text;
using Learning.Math;

namespace Learning
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public char Gender;
        public int Age;
        

        public Person()
        {
        }

        public void AddPerson(string firstName, string lastName, char gender, int age)
        {
            FirstName = firstName;
            LastName =  lastName.ToUpper();
            Gender = Char.ToUpper(gender);
            Age = age;
        }

        public string GetName()
        {
            return $"{FirstName} {LastName}";
        }
        public string GetPerson()
        {
            return $"Name: {FirstName} {LastName} // Gender: {Gender} // Age: {Age}";
            
        }

       
    }
}
