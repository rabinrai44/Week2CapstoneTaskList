using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskListMager
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            Console.Write("\nWhat would you like to do? ");
            Console.ReadKey();
        }

        static void PrintHeader()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\tWelcome to the Task Manager!");
            Console.WriteLine("---------------------------------------------\n");
            Console.WriteLine(String.Format(" {0, 4} - {1, -4}", 1, "List Tasks"));
            Console.WriteLine(String.Format(" {0, 4} - {1, -4}", 2, "Add Task"));
            Console.WriteLine(String.Format(" {0, 4} - {1, -4}", 3, "Delete Task"));
            Console.WriteLine(String.Format(" {0, 4} - {1, -4}", 4, "Mark Complete"));
            Console.WriteLine(String.Format(" {0, 4} - {1, -4}", 5, "Quit"));            
        }
    }
}
