using System;
using ClassWrk_Polymorphism_Interface.Services.Interfaces;

namespace ClassWrk_Polymorphism_Interface.Services
{
    public class EmployeeService : IEmployeeService

    {
        public void Search(string searchText)
        {
            string[] employees = {"Pervin","Sheref","Chahangir","Fidan","Kubra"};

            foreach (var item in employees)
            {
                if (item.Contains(searchText))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

