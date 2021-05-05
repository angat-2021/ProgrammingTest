using System;

namespace CompositionSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var enrollment = new Enrollment();

            var student = new Student(enrollment);

            student.Transcript();
        }   
    }
}
