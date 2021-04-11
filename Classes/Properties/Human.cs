using System;

namespace Properties
{
    public class Human
    {
        //prop-> short for properties
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        //Constructor
        public Human(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        //Calculated Properties
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
