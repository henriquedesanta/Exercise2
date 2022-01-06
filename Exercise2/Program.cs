using System;
using Exercise2.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int employees = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Employee> list = new List<Employee>();

            for (int i = 1; i < employees; i++)
            {
                Console.WriteLine($"Employee #{i} data");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuehour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                if (ch == 'y')
                {
                    Console.WriteLine("Additional Charge: ");
                    double AdditCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutSourcedEmployee(name, hour, valuehour, AdditCharge));
                }
                else
                {
                    list.Add(new Employee(name, hour, valuehour));
                }



            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
