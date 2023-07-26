using System;
namespace ClassWrk_Polymorphism_Interface.Services.Interfaces
{
	public interface ICustomMathService
	{
		void Sum(int a,int b);

		int GetNumbersOfSum(int[] nums);

		double PowOfNum(int num,int pow);
	}
}

