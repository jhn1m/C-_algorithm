using System;
using static System.Console;
namespace Baekjoon
{
	public class main 
	{
		public static void Main() 
		{
			string input = Console.ReadLine();
			string [] input_array = input.Split();
			int a = int.Parse(input_array[0]);
			int b = int.Parse(input_array[1]);
			int c = int.Parse(input_array[2]);
			
			WriteLine( (a + b) % c);
			WriteLine( ((a % c) + (b % c)) % c);
			WriteLine( (a * b) % c);
			WriteLine( ((a % c) * (b % c)) % c);
		}
	}
}
