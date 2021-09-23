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
			double a = int.Parse(input_array[0]);
			double b = int.Parse(input_array[1]);
			
			WriteLine(a / b);
		}
	}
}
