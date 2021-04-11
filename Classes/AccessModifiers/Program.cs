using System;

namespace AccessModifiers
{
    public class Person
    {   //Private access modifier allows private memebers of the class inaccessible outside that class.
        private DateTime _birthdate;
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
         public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1998, 1, 1));
            Console.WriteLine(person.GetBirthdate());
            
        }
    }
}
