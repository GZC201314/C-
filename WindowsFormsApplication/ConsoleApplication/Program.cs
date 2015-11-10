using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个字符串:");
            string welcomString = Console.ReadLine();
            Console.WriteLine("Welcome:{0}",welcomString);
            Console.ReadKey();
        }
    }
}
