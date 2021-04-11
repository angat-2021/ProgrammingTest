using System.Collections.Generic;
//We use constructors to initialize an object and put it in an early state.
namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        //Constructor -->ctor tab tab shortcuts to create Construtors
        //public Customer()
        //{
        //    Rule of thumb: whenever we have a class and that class has a list of object, the list must be initialized
        //    Orders = new List<Order>();
        //}
        //public Customer(int id):this()
        //{
        //    this.Id = id;
        //}
        //public Customer(int id, string name):this(id)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //}
    }
}
