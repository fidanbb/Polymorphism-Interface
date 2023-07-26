using System;
using ClassWrk_Polymorphism_Interface.Helpers.ResponseMessages;
using ClassWrk_Polymorphism_Interface.Services.Interfaces;

namespace ClassWrk_Polymorphism_Interface.Services
{
    public class AccountService : IAcccountService
    {
        //public string Login(string email, string password)
        //{
        //    if (email=="x@gmail.com"&& password =="x123")
        //    {
        //        return AccountMessages.LoginSuccess;
        //    }
        //    return AccountMessages.LoginFailed;
        //}

        public bool Login(string email, string password)
        {
            if (email == "x@gmail.com" && password == "x123")
            {
                return  true;
            }
            return false;
        }
    }
}

