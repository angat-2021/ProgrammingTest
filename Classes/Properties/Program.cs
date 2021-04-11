using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Properties are the class members that encapsulate getter and setter for accessing a field.
            //Why? To create a getter/setter with less code.
            /*
             *  private DateTime _birthdate;
         public void SetBirthdate(DateTime birthdate)
         {
             _birthdate = birthdate;
         }
          public DateTime GetBirthdate()
         {
             return _birthdate;
         }
            //can be written as following (Pascal Case Naming Convention)
            public DateTime Birthdate
            {
            get {return _birthdate;}
            set {_birthdate=value;}           
            }
            OR 
            public DateTime Birthdate {get;set;}
             */
            var human = new Human(new DateTime(1998, 08, 06));
            
            Console.WriteLine(human.Age);
            
        }
    }
}
