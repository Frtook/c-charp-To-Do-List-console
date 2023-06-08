using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Task
    {
        static List<string> tasks = new List<string>();

        static void is_tasks_empty()
        {
            if (tasks.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No Task Today ");
            }
        }

        static void print_tasks()
        {
            if (tasks.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Task Today is :");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to mine Task");
            bool loop = true;

            do
            {
                Console.Write("\nEnter 1 to Add Task :\nEnter 2 to View Task:\nEnter 3 to Reomve Task:\nEnter 4 to Exit:");
                string t = Console.ReadLine();

                switch (t)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Enter Name Task :");
                        string task = Console.ReadLine();
                        tasks.Add(task);
                        Console.WriteLine("Task is Added");

                        break;

                    case "2":
                        is_tasks_empty();
                        print_tasks();
                        break;

                    case "3":
                        is_tasks_empty();
                        print_tasks();
                        if (tasks.Count > 0)
                        {
                            Console.Write("Enter Number The Task To Remove:");
                            try
                            {
                                int num_task = int.Parse(Console.ReadLine());
                                tasks.Remove(tasks[num_task - 1]);
                                Console.WriteLine("Task is Removed");
                            }
                            catch
                            {
                                Console.WriteLine("Error try again !");
                            }
                        }
                        break;
                    case "4":
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Enter 1 to 4 !");
                        break;

                }

            } while (loop);


        }
    }
}
