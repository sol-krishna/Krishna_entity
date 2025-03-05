using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Driver
    {
        private bool isRunning;
        private ConstantsService constantsService;

        public Driver() 
        {
            constantsService = new ConstantsService();
        }

        public void Start()
        {
            isRunning = true;
            while(isRunning) 
            {
                Console.WriteLine("Enter 1 to create a new constant value");
                Console.WriteLine("Enter 2 to get all constants");
                Console.WriteLine("Enter 3 to start updating a constant");
                Console.WriteLine("Enter 4 to start removing a constant value");
                Console.WriteLine("Type exit to close the application");
                var userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "1":
                        constantsService.CreateNewConstant();
                        break;
                    case "2":
                        foreach (var constant in constantsService.GetAllConstants())
                        {
                            Console.WriteLine(constant.ToString());
                        }
                        break;
                    case "3":
                        constantsService.UpdateConstant();
                        break;
                    case "4":
                        constantsService.DeleteConstant();
                        break;
                    case "exit":
                        isRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
