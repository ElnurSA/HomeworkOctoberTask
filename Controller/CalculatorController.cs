using System;
using TaskOctober.Service;

namespace TaskOctober.Controller
{
	public class CalculatorController : CalculatorService
	{
		CalculatorService calculatorService = new();

		public void WriteNums()
		{
            var a = int.Parse(Console.ReadLine());
			
            var b = int.Parse(Console.ReadLine());

			calculatorService.Calculator(a, b);
        }
	}
}

