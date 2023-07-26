using System;
namespace ClassWrk_Polymorphism_Interface
{
	public class Employee:IEmployee,ICommon
	{
		public int Age { get; set; }

        public string Name { get; set; }

        public string GetAddress()
        {
            return "Address";
        }

        public string GetFullName()
        {
            throw new NotImplementedException();
        }

        //public void GetAge()
        //{
        //    Console.WriteLine("Age");
        //}

        //public void GetName()
        //{
        //    Console.WriteLine("Name");
        //}
    }
}

