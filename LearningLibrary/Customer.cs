using System;
using System.Collections.Generic;
using System.Text;

namespace LearningLibrary
{
   public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders; //to not accidently call it in another method and set a new empty list and lose all data
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }
        public Customer(int id, string name):
            this(id)
        {           
            this.Name = name;
        }

        public void Promote() 
        {
           
        }
    }
}
