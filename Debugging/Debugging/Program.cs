using System;
using System.Collections.Generic;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {

            //F9- put breakpoint
            //F5 - run in debug mode
            //ctrl+F5 -run without debug
            // F10 -step over line at a time execution
            // F11- stepinto the line 
            //Shift+F11 - Step Out
            //ctrl+F5 -run without debug
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6,0,-1,-5,0,-1};
            var smallests = GetSmallests(numbers, 3);
            foreach (var item in smallests)
            {
                Console.WriteLine(item);

            }
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (list==null)
            {
                throw new ArgumentOutOfRangeException("list", "list is null");
            }
            if (count>list.Count || count<=0)
            {
                throw new ArgumentOutOfRangeException("count", "count should be between 1 and number of elements in the list.");
            }
            List<int> buffer = new List<int>(list);
            List<int> smallests = new List<int>();
            while (smallests.Count<count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }
            return smallests;
        }
        public static int GetSmallest (List<int> list)
        {
            //assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i]<min)
                {
                    min = list[i];
                }
            }
                return min;
        }
    }
}
