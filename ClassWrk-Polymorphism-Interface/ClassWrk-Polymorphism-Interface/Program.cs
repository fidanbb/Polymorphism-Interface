using ClassWrk_Polymorphism_Interface;
using ClassWrk_Polymorphism_Interface.Controllers;
using ClassWrk_Polymorphism_Interface.Services;
using ClassWrk_Polymorphism_Interface.Services.Interfaces;

//Bird bird = new();

//bird.Sound();
//bird.Eating();

//Animal animal = new Bird();

//Bird bird1 = new Bird();

//Animal bird2 = new Bird();

//Person person = new();

//IPerson person = new Person();


//person.GetName();

//Employee employee = new();

//employee.GetName();
//Console.WriteLine(employee.GetAddress());

//employee.MyProperty = 43;

//ICustomMathService customMathService = new CustomMathService();

//customMathService.Sum(4,7);

//Console.WriteLine(customMathService.GetNumbersOfSum(new int[] {1,2,3,4}));

//IEmployeeService employeeService = new EmployeeService();

//employeeService.Search("e");

//Console.WriteLine(customMathService.PowOfNum(6,2));

AccountController accountController = new();

accountController.Login();
