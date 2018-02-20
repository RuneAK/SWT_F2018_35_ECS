using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS
{
	class Program
	{
		static void Main(string[] args)
		{
            var test = new SimpleTestClass();
		    int a = 4;
		    int b = 6;
		    Console.WriteLine($"The result of {a} + {b} is {test.Add(a,b)}");
		    Console.ReadLine();
		}
	}
}
