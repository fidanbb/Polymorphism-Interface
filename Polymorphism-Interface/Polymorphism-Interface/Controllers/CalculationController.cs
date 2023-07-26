using System;
using Polymorphism_Interface.Services;
using Polymorphism_Interface.Services.Interfaces;

namespace Polymorphism_Interface.Controllers
{
	public class CalculationController
	{
		ICalculationService _calculationService;
		
		public CalculationController()
		{
			_calculationService = new CalculationService();
		}

		public void Calculate()
		{
			string[] operations = { "+", "-", "*", "/" };

            Num1:Console.WriteLine("Add first number: ");
			int num1;
		     bool isNumber1 = int.TryParse(Console.ReadLine(), out num1);

			Console.WriteLine("Add operation");
			string operation = Console.ReadLine();

            Console.WriteLine("Add second number: ");
            int num2;
            bool isNumber2 = int.TryParse(Console.ReadLine(), out num2);

            

            if (isNumber1 && isNumber2 && operations.Contains(operation))
			{
				if (num2==0 && operation =="/")
				{
					Console.WriteLine("You can not divide 0 ");
				}

				else
				{
                    var result = _calculationService.Calculate(num1,operation,num2);
					Console.WriteLine(result);

                }
			}

			else
			{
				Console.WriteLine("Numbers or operation is incorrect, pls try again");
				goto Num1;
			}


        }
	}
}

