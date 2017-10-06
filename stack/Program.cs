using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            var stack = new Stack<int>();

            Console.WriteLine(stack.Empty());

            stack.Push(7);
            stack.Push(13);
            stack.Push(2);
            var head = stack.Pop();
            Console.WriteLine(head);

            head = stack.TakeElement();
            Console.WriteLine(head);

            Console.WriteLine(stack.Empty());

            Console.ReadKey();
        }
    }
}
