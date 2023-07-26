using System;
namespace ClassWrk_Polymorphism_Interface
{
    public class Bird : Animal
    {
        public int Age { get; set; }

        public Bird()
        {
            //Console.WriteLine("hello world");

            Eating();
        }
        //public override void Sound()
        //{
        //    Console.WriteLine("bird sound");
        //}

        public override void Eating()
        {
            Console.WriteLine("bird eating");
        }


    }
}

