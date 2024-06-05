using System;
using System.ComponentModel.Design;

namespace HelloWorld
{/*Multi Line Comments
  * Used to put everything inbetween as a comment
  */
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            string[] options = {"Create", "Read", "Update", "Delete","Exit"};
            string input;
            String[] employees = new string[100];
            bool Continue = true;


            //Input
            while (Continue)
            {
                Console.WriteLine("");
                Console.WriteLine("What would you like to do");
                    for (int identifier = 0; identifier < options.Length;identifier++)
                      {
                            Console.WriteLine(options[identifier]);
                      }
                Console.Write("Selection: ");
                     input = Console.ReadLine();

                switch (input)
                {
                    case "Create":
                        Console.Write("Enter employee name: ");
                        String newemployee = Console.ReadLine();

                        for (int i = 0; i < employees.Length; i++)
                        {
                            if (employees[i] == null)
                            {
                                employees[i] = newemployee;
                                Console.WriteLine("Employee added as :Index["+Convert.ToString(i) + "] "+newemployee);
                                return;
                            }
                       
                        }
                       
                        break;
                    case "Read":
                        foreach (string employee in employees)
                        {
                            Console.WriteLine("Employee Name: " + employee);
                        }
                        break;
                    case "Update":
                        Console.WriteLine("Which Employee name would you like to update?( Select the index between 0 and "+ Convert.ToString(employees.Length-1));
                        int Uindex = 0;
                        foreach (string employee in employees)
                        {
                            Console.WriteLine("Employee Name: Index["+ Convert.ToString(Uindex) + "] employee");
                            Uindex++;
                        }
                        Console.Write("Index: ");
                        Uindex = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You have selected " + employees[Uindex] + ", Please type the name you would like to change it to.");
                            string oldname = employees[Uindex];
                        Console.Write("New Name: ");
                            employees[Uindex] = Console.ReadLine();
                        Console.WriteLine("You have changed " + oldname + " to " + employees[Uindex]);
                        break;
                    case "Delete":
                        Console.WriteLine("Which Employee would you like to remove?( Select the index between 0 and " + Convert.ToString(employees.Length - 1));
                        Uindex = 0;
                        foreach (string employee in employees)
                        {
                            Console.WriteLine("Employee Name: " + Convert.ToString(Uindex) + " " + employee);
                            Uindex++;
                        }
                        Console.Write("Index: ");
                        Uindex = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You have selected " + employees[Uindex] + ", Please confirm if you would like to delete this Employee from the records");
                        oldname = employees[Uindex];
                        employees[Uindex] = null;
                        Console.WriteLine("You have Deleted " + oldname + " from the System " );
                        break;
                    case "Exit":
                        Continue= false;
                        break;
                    default:
                        Console.WriteLine($"{input} is an invalid selection");
                        break;
                }


            }

        }
    }
}

           