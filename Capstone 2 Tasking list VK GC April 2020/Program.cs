using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Capstone_2_Tasking_list_VK_GC_April_2020
{
    class Program
    {

        //1. Create the task list class 

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Task List Navigation sytem.");

            List<TaskList> taskList = TaskList.GetTaskList();

            while (true)
            {

                TaskList.DisplayTaskMenu();

                string input = GetUserInput("Enter a number to proceed: ");

                switch (input)
                {
                    case "1":
                        TaskList.DisplayTasks(taskList);
                        break;
                    case "2":
                        TaskList.AddTask(taskList);
                        break;
                    case "3":
                        TaskList.DisplayTasks(taskList);
                        input = GetUserInput("Which task do you want to delete?");
                        int index = ParseInt(input)-1;
                        TaskList task = taskList[index];
                        //taskList.Remove(task);
                        //taskList.RemoveAt(index);
                        TaskList.DeleteTask(taskList, taskList[index-1]);
                        TaskList.UserContinue($"Are you sure you want to delete task {input}?");
                        break;
                    case "4":
                        TaskList.DisplayTasks(taskList);
                        input = GetUserInput("Which task do you want to mark complete?");
                        index = ParseInt(input) - 1;
                        task = taskList[index];
                        TaskList.MarkTaskComplete(taskList, taskList[index - 1]);
                        TaskList.UserContinue($"Are you sure you want to mark task {input} complete?");
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;

                }
            }

            //TaskList tasklist = new TaskList();
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int ParseInt(string input)
        {
            while(true)
            {
                try
                {
                    return int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Entry not valid. Please input a valid number.");
                }
            }
        }
    }
}
