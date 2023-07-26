using System;
using ClassWrk_Polymorphism_Interface.Services.Interfaces;

namespace ClassWrk_Polymorphism_Interface.Services
{
    public class CustomMathService : ICustomMathService

	{
        public int GetNumbersOfSum(int[] nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }

            return sum;
        }

        public double PowOfNum(int num,int pow)
        {
            return Calculate(num, pow);
        }

        private double Calculate(int num,int pow)
        {
            var result = Math.Pow(num, pow);
            return result;
        }

        public void Sum(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }
    }
}

