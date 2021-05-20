using System;
using System.Collections.Generic;

namespace ExerciseInheritance
{
    public class Stack
    {
        private readonly List<object> objects = new List<object>();
        public void Push(object obj)
        {
            if (obj ==null)
            {
                throw new InvalidOperationException("You can not add a null object to the stack");
            }
            objects.Add(obj);
        }

        public object Pop()
        {
            if (objects.Count == 0)
            {
                throw new InvalidOperationException("There are no elements in the stack.");
            }

            int index = objects.Count - 1;
            object toBeReturned = objects[index];

            objects.RemoveAt(index);

            return (toBeReturned);
        }

        public void Clear()
        {
            objects.Clear();
            Console.WriteLine("All the objects are removed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            int min = 1;
            int max = 7;

            for (int i = min; i <=max; i++)
            {
                stack.Push(i);
            }
            //stack.Clear();
            for (int i = min; i <=max; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            stack.Clear();

            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
