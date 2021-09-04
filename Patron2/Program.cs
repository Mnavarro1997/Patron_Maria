using System;

namespace Patron2
{
    internal class Program
    {
       private static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine(@"
					To run tests write:
					testAll
					test1
					test2
					test3
					");
				var instrucction = Console.ReadLine();
				if (instrucction == "testAll")
				{
					SampleTests.Test1();
					SampleTests.Test2();
					SampleTests.Test3();
				}
				else if (instrucction == "test1")
					SampleTests.Test1();
				else if (instrucction == "test2")
					SampleTests.Test2();
				else if (instrucction == "test3")
					SampleTests.Test3();
				}
		}
    }
}
