using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipApplication
{
    class CustomerManager
    {
        private List<Customer> customers = new List<Customer>();
        private int lastId = 0; // Variable to keep Id values consecutive

        public void AddCustomer()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter customer surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter customer VAT nr: ");
            string vat_nr = Console.ReadLine();
            Console.Write("Enter customer address: ");
            string address = Console.ReadLine();
            Customer customer = new Customer(name, surname, vat_nr, address);
            customer.Id = ++lastId;
            customers.Add(customer);
            Console.WriteLine("\nCustomer added successfully.");
        }

        public void ListCustomers()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers found.");
            }
            else
            {
                ShowCustomers();
            }
        }
        public void ShowCustomers()
        {
            Console.WriteLine("List of customers:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.Id}. Name: {customer.Name}, Surname: {customer.Surname}, VAT identification number: {customer.VAT_nr}, Creation date: {customer.Creation_date.ToShortDateString()}, Address: {customer.Address}");
            }
        }
        public void EditCustomer()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers found.");
            }
            else
            {
                ShowCustomers();
                int id = 0;
                Console.Write("\nEnter the number of customer to edit: ");
                try
                {
                    id = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid customer number. Try again.");
                    return;
                }
                Customer customerToEdit = customers.Find(c => c.Id == id);
                if (customerToEdit == null)
                {
                    Console.WriteLine("Customer not found.");
                    return;
                }
                Console.Write("Enter property name to edit (name/surname/VAT_nr/address): ");
                string property = Console.ReadLine();
                switch (property.ToLower())
                {
                    case "name":
                        Console.Write("Enter new name value: ");
                        customerToEdit.Name = Console.ReadLine();
                        break;
                    case "surname":
                        Console.Write("Enter new surname value: ");
                        customerToEdit.Surname = Console.ReadLine();
                        break;
                    case "vat_nr":
                        Console.Write("Enter new VAT identification number value: ");
                        customerToEdit.VAT_nr = Console.ReadLine();
                        break;
                    case "address":
                        Console.Write("Enter new address value: ");
                        customerToEdit.Address = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid property name. Try Again.");
                        return;
                }
                Console.WriteLine("Customer updated successfully.");
                return;
            }
        }
        public void DeleteCustomer()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers found.");
            }
            else
            {
                ShowCustomers();
                Console.WriteLine("");
                int id = 0;
                Console.Write("Enter the numer of the customer to delete: ");

                try
                {
                    id = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid customer number. Try Again.");
                    return;
                }

                Customer customerToDelete = customers.Find(c => c.Id == id);
                if (customerToDelete == null)
                {
                    Console.WriteLine("Customer not found.");
                    return;
                }
                customers.Remove(customerToDelete);
                Console.WriteLine("Customer deleted successfully.");

                // Reassigning Id values to ensure they are consecutive
                for (int i = 0; i < customers.Count; i++)
                {
                    customers[i].Id = i + 1;
                }
                lastId = customers.Count;
            }
        }
    }
}
