using System;
using System.Collections.Generic;

namespace Fields
{
    public class Person
    {
        private DateTime _birthdate;

    }
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders=new List<Order>();

        
        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name):this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>(); -->Not acceptable
            //...
        }
    }
}
