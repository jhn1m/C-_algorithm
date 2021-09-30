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
			
			if((a % 4 == 0 && a % 100 != 0) || (a % 400 == 0))
				WriteLine("1");
			else
				WriteLine("0");
		}
	}
}
