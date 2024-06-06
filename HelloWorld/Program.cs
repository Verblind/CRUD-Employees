using System;

namespace CRUD
{
    class Program
    {
        static string[] employees = new string[] { "Jeremy de Lange", "Alexander Lee" };

        static void Main(string[] args)
        {

            string[] options = { "Create", "Read", "Update", "Delete", "Exit" };
            string input;

            bool Continue = true;


            while (Continue)
            {
                Console.WriteLine("");
                Console.WriteLine("What would you like to do");
                for (int identifier = 0; identifier < options.Length; identifier++)
                {
                    Console.WriteLine(options[identifier]);
                }
                Console.Write("Selection: ");
                input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "CREATE":

                        Create();

                        break;

                    case "READ":

                        MRead();

                        break;

                    case "UPDATE":

                        MUpdate();

                        break;

                    case "DELETE":

                        Delete();

                        break;

                    case "EXIT":

                        Continue = false;

                        break;
                    default:
                        Console.WriteLine($"{input} is an invalid selection");
                        break;
                }


            }

        }

        static void Create()
        {
            int newIndex = employees.Length + 1;
            Console.Write("Enter employee name: ");
            String newemployee = Console.ReadLine();


            employees = employees.Append(newemployee).ToArray();

            Console.WriteLine(newemployee + " has been added");

        }

        static void MRead()
        {
            foreach (string employee in employees)
            {
                Console.WriteLine("Employee Name: " + employee);
            }
        }
        static void MUpdate()
        {
            Console.WriteLine("Which Employee name would you like to update?( Select the index between 0 and " + Convert.ToString(employees.Length));
            int Uindex = 0;
            foreach (string employee in employees)
            {
                Console.WriteLine("Employee Name: Index[" + Convert.ToString(Uindex) + "] " + employee);
                Uindex++;
            }
            Console.Write("Index: ");
            Uindex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have selected " + employees[Uindex] + ", Please type the name you would like to change it to.");
            string oldname = employees[Uindex];
            Console.Write("New Name: ");
            employees[Uindex] = Console.ReadLine();
            Console.WriteLine("You have changed " + oldname + " to " + employees[Uindex]);
            return;
        }

        static void Delete()
        {
            Console.WriteLine("which employee would you like to remove?( select the index between 0 and " + Convert.ToString(employees.Length - 1));
            int uindex = 0;
            foreach (string employee in employees)
            {
                Console.WriteLine("employee name: " + Convert.ToString(uindex) + " " +employee);
                uindex++;
            }
            Console.Write("index: ");
            uindex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Employee [" + Convert.ToString(uindex) + "] " + employees[uindex] + " Has been Deleted");
            employees = employees.Where((x, i) => uindex != i).ToArray();

            //test

        }

    }
}

