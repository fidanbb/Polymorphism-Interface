using System;
namespace ClassWrk_Polymorphism_Interface
{
	public class Student:IStudent,ICommon
	{
		public string FullName { get; set; }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetAge()
        {
            throw new NotImplementedException();
        }

        public string GetFullName()
        {
            throw new NotImplementedException();
        }

        public void GetName()
        {
            throw new NotImplementedException();
        }

        public void ShowAge()
        {
            Console.WriteLine(30);
        }
    }
}

