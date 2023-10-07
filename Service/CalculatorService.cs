using System;
namespace TaskOctober.Service
{
	public class CalculatorService
	{
		public void Calculator(int a, int b)
		{
			int sum = 0;
			int substraction = 0;
			int division = 1;
			int multiply = 1;

			sum = a + b;
			substraction = a - b;
			multiply = a * b;

			if (a != 0 && b != 0)
			{
				division = a / b;
			}
			else
			{
				Console.WriteLine("You can't divide by 0");
			}

			Console.WriteLine(sum);
			Console.WriteLine(substraction);
			Console.WriteLine(division);
			Console.WriteLine(multiply);
        }
	}
}

