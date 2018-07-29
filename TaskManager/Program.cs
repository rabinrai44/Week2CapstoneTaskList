using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Program
    {
        //CONST VARIABLE
        private const string MENU_COLUM_FORMAT = " {0, 4} - {1, -4}";
        private const string TASK_COLUM_FORMAT = "{0, -12} {1, -12} {2, -12} {3, -12}";
        private const string LINE_SHORT = "---------------------------------------------";
        private const string LINE_LONG = "---------------------------------------------------------------------------------------------------------------------";

        static void Main(string[] args)
        {

            //variables 
            int userChoice;
            bool start = true;
            do
            {
                PrintHeader();

                try
                {

                    Console.Write("\nWhat would you like to do? ");
                    userChoice = int.Parse(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            ListTask();
                            break;
                        case 2:
                            //AddTask();
                            break;
                        case 3:
                            //DeleteTask();
                            break;

                        case 4:
                            //MarkTaskComplete();
                            break;
                        case 5:
                            Console.WriteLine("Have a great day!");
                            break;
                        default:
                            Console.WriteLine("Invalid selection! Please try again.");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (ShouldContinue());

            Console.ReadKey();
        }

        private static bool ShouldContinue()
        {
            do
            {
                Console.WriteLine("\nWould you want to continue (y/n)?");
                var userResponse = Char.ToLower(Console.ReadKey().KeyChar);

                if (userResponse != 'y' && userResponse != 'n')
                    continue;
                else
                    return userResponse == 'y';

            } while (true);
        }

        // List Task
        private static void ListTask()
        {
            Console.WriteLine("\nLIST TASKS");
            TaskHeaderStyle();
            SampleTask();
        }

        //Sample Task list
        private static void SampleTask()
        {
            Console.WriteLine(TASK_COLUM_FORMAT, "True", "07/29/2018", "Rabin", "Create a header method");
            Console.WriteLine(TASK_COLUM_FORMAT, "False", "07/30/2018", "Sean", "Create a method for add task");
        }

        private static void TaskHeaderStyle()
        {
            Console.WriteLine(LINE_LONG);
            Console.WriteLine(TASK_COLUM_FORMAT, "Done?", "Due Date", "Team Member", "Description");
            Console.WriteLine(LINE_LONG);
        }

        static void PrintHeader()
        {
            Console.WriteLine(LINE_SHORT + "\n\tWelcome to the Task Manager!\n" + LINE_SHORT + "\n");
            Console.WriteLine(MENU_COLUM_FORMAT, 1, "List Tasks");
            Console.WriteLine(MENU_COLUM_FORMAT, 2, "Add Task");
            Console.WriteLine(MENU_COLUM_FORMAT, 3, "Delete Task");
            Console.WriteLine(MENU_COLUM_FORMAT, 4, "Mark Complete");
            Console.WriteLine(MENU_COLUM_FORMAT, 5, "Quit");            
        }
    }
}
