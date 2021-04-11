using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Angat";
            Console.WriteLine(cookie["name"]);

        }
    }
}
