using System;
using static System.Console;
namespace Baekjoon
{
	public class main
	{
		public static void Main() 
		{
			int a;
			
			a = Convert.ToInt32(Console.ReadLine());
			
			if(a <= 100 && a >= 90)
				WriteLine("A");
			else if(a <= 89 && a >= 80)
				WriteLine("B");
			else if(a <= 79 && a >= 70)
				WriteLine("C");
			else if(a <= 69 && a >= 60)
				WriteLine("D");
			else
				WriteLine("F");
		}
	}
}
