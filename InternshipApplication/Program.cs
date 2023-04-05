using System;

namespace InternshipApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            while (true)
            {
                Console.WriteLine("1. Add customer");
                Console.WriteLine("2. List customers");
                Console.WriteLine("3. Edit customer");
                Console.WriteLine("4. Delete customer");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        customerManager.AddCustomer();
                        break;
                    case "2":
                        customerManager.ListCustomers();
                        break;
                    case "3":
                        customerManager.EditCustomer();
                        break;
                    case "4":
                        customerManager.DeleteCustomer();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}