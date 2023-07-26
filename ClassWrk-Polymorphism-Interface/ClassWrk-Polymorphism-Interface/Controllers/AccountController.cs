using System;
using ClassWrk_Polymorphism_Interface.Helpers.ResponseMessages;
using ClassWrk_Polymorphism_Interface.Services;

namespace ClassWrk_Polymorphism_Interface.Controllers
{
	public class AccountController
	{
		private readonly AccountService _accountService;

		public AccountController()
		{
			_accountService = new AccountService();
		}

        //public void Login()
        //{
        //	Console.WriteLine("Email");
        //	string email = Console.ReadLine();

        //	Console.WriteLine("Password");
        //	string password = Console.ReadLine();

        //	string result = _accountService.Login(email, password);

        //	Console.WriteLine(result);
        //}

        public void Login()
        {
            Console.WriteLine("Email");
            Email: string email = Console.ReadLine();

            Console.WriteLine("Password");
            string password = Console.ReadLine();

            bool isLogin = _accountService.Login(email, password);

            if (isLogin)
            {
                Console.WriteLine(AccountMessages.LoginSuccess);
                Console.WriteLine("Welcome: "+ email);
            }
            else
            {
                Console.WriteLine(AccountMessages.LoginFailed);
                goto Email;
            }
        }
    }
}

