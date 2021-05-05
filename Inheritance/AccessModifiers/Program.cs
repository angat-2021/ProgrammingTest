using Amazon;

namespace AccessModifiers
{   
    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            //Can not instanciate a ovject from a class from another assembly that is internal 
            //Amazon.RateCalculator calculator = new RateCalculator();
            
        }
    }
}
