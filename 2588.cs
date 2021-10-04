using System;
using static System.Console;
namespace Baekjoon
{
	public class main 
	{
		public static void Main()  
		{
			int a, b;
			
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			
			WriteLine(a * (b % 10) );
			WriteLine(a * (b % 100 / 10) );
			WriteLine(a * (b / 10 / 10) );
			WriteLine(a * b);
		}
	}
}
