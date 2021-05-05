using System;

namespace CompositionSampleApp
{
    public class Enrollment
    {
        public DateTime DateOfBirth { get; set; }

        public void Status(string status)
        {
            Console.WriteLine(status);
        }
    }
}
