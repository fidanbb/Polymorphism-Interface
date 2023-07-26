using System;
namespace ClassWrk_Polymorphism_Interface
{
	public class Animal
	{
		//public readonly string Address;
		//public string Phone { get; private set; }


        public string Name { get; set; }

		//public abstract void Sound();


		public virtual void Eating()
		{
			Console.WriteLine("animal eating");
		}

	}
}

