namespace CompositionSampleApp
{
    public class Student
    {
        private readonly Enrollment _enrollment;

        public Student(Enrollment enrollment)
        {
            _enrollment = enrollment;
        }

        public void Transcript()
        {
            _enrollment.Status("Transcript is issued.");
        }
    }
}
