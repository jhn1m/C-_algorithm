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
			
			if(a > b)
				WriteLine(">");
			else if(a < b)
				WriteLine("<");
			else
				WriteLine("==");
		}
	}
}
