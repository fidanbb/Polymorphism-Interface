using System;
namespace ClassWrk_Polymorphism_Interface
{
    public class Person : IPerson
    {
        public string Name { get; set; }

        public void GetAge()
        {
            Console.WriteLine(22);
        }

        public void GetName()
        {
            Console.WriteLine("Fidan");
        }
    }
}

