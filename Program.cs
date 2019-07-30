using System;
using System.Collections.Generic;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {
            try {
                List<Employee> list = new List<Employee>();
                do {
                    Console.Clear();
                    Console.WriteLine("1- Increment Employee");
                    Console.WriteLine("2- Show Emplyees");
                    Console.WriteLine("3- Alter Salary of Emplyees");
                    int option = int.Parse(Console.ReadLine());

                    switch (option) {
                        case 1: //Increment Employee
                            Console.WriteLine("How many employees will be registred?");
                            int amount = int.Parse(Console.ReadLine());
                            for (int i = 0; i < amount; i++) {
                                Employee a = new Employee();
                                Console.Write("Id: ");
                                a.Id = int.Parse(Console.ReadLine());
                                Employee test = list.Find(x => x.Id == a.Id);
                                if (test == null)
                                {
                                    Console.Write("Name: ");
                                    a.Name = Console.ReadLine();
                                    Console.Write("Salary: ");
                                    a.Salary = double.Parse(Console.ReadLine());
                                    list.Add(a);
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("Employee already registered!");
                                    Console.WriteLine(test);
                                    Console.ReadLine();
                                }
                            }
                            break;

                        case 2: //Show Employees
                            if (list.Count != 0) {
                                foreach (Object obj in list) {
                                    Console.WriteLine(obj);
                                }
                            } else
                                Console.WriteLine("Don't have registered Employees.");
                            Console.ReadLine();
                            break;

                        case 3: //Update Employee Salary
                            Console.Clear();
                            Console.WriteLine("Enter the employee Id that will have salary increase: ");
                            int upSalarayEmployee = int.Parse(Console.ReadLine());
                            Employee up = list.Find(x => x.Id == upSalarayEmployee);
                            if (up != null)
                                up.UpdateSalary(10);
                            else {
                                Console.WriteLine("Employee is not found");
                            }
                            break;
                    }
                } while (true);

            }
            catch {
                Console.WriteLine("Invalid Option");
            }
        }
    }
}
