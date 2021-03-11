using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._3
{
    class Program
    {
        private static int Add(int x, int y)
        {
            return x + y;
        }
        public delegate int Operation(int x, int y);
        private static int Calculator(Operation oper_func, int x, int y)
        {
            int result = oper_func.Invoke(x, y);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Calculator(Add, 1,2));
        }

    }
}
