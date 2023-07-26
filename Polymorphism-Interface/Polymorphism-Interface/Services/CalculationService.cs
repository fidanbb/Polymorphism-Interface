using System;
using Polymorphism_Interface.Services.Interfaces;

namespace Polymorphism_Interface.Services
{
	public class CalculationService:ICalculationService
	{
	

        public double Calculate(double num1, string operation, double num2)
        {
            double result;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    return result;
                   
                case "-":
                    result = num1 - num2;
                    return result;
                   
                case "*":
                    result = num1 * num2;
                    return result;
                  
                case "/":
                    result = num1 / num2;
                    return result;
                    
                default:
                    return -1;

            }
        }
    }
}

