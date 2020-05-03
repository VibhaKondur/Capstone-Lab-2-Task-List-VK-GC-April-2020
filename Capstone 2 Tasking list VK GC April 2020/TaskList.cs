using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_2_Tasking_list_VK_GC_April_2020
{
    class TaskList
    {
        //2. Create our fields        
        private string teamMemberName;
        private string description;
        private DateTime dueDate;
        private bool complete;

        //3. Create our properties -- getters and setters        
        public string TeamMemberName
        {
            get
            {
                return teamMemberName;

            }
            set
            {
                teamMemberName = value;
            }
        }
        public string Description
        {
            get
            {
                return description;

            }
            set
            {
                description = value;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }

        public bool Complete
        {
            get
            {
                return complete;
            }
            set
            {
                complete = value;
            }

        }

        //Created default constructor for TaskList class
        public TaskList()
        {

        }

        //Created overloaded constructor for TaskList class
        public TaskList(string _teamMemberName, string _description, DateTime _dueDate, bool _complete)
        {
            teamMemberName = _teamMemberName;
            description = _description;
            dueDate = _dueDate;
            complete = _complete;

        }

        //method to display task list menu
        public static void DisplayTaskMenu()
        {
            Console.WriteLine("1. List Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Mark Task Complete");
            Console.WriteLine("5. Quit");
        }

        //method to list tasks 
        public static List<TaskList> GetTaskList()
        {
            List<TaskList> taskList = new List<TaskList>
            {
                new TaskList("Mr. Fantastic", "Speaks all the science", DateTime.Parse("11/5/1988"), true),
                new TaskList("Invisible Woman", "Disappears", DateTime.Parse("7/4/2020"), false),
                new TaskList("Thing", "Smashes stuff", DateTime.Parse("5/5/1905"), true),
                new TaskList("Human Torch", "Sets everything on fire", DateTime.Parse("1/1/2000"), false),
            };
            return taskList;
        }

        //method to display tasks for members in group
        public static void DisplayTasks(List<TaskList> taskList)
        {
            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{i + 1}: ");
                Console.WriteLine($"{taskList[i].TeamMemberName}");
                Console.WriteLine($"{taskList[i].Description}");
                Console.WriteLine($"{taskList[i].DueDate}");
                Console.WriteLine($"{taskList[i].Complete}");
                Console.WriteLine();
            }
        }

        //method to add tasks to the list
        public static void AddTask(List<TaskList> taskList)
        {
            //Creating a "Task" object

            TaskList task = new TaskList();

            Console.WriteLine("Enter member's name: ");
            task.TeamMemberName = Console.ReadLine();

            Console.WriteLine("Enter Description: ");
            task.Description = Console.ReadLine();

            Console.WriteLine("Enter Due Date (mm/dd/yyyy) : ");
            task.DueDate = DateTime.Parse(Console.ReadLine());

            task.Complete = false;

            taskList.Add(task);

            Console.WriteLine("Task entered!");



        }

        //method to ask the user to continue 
        public static bool UserContinue(string message)
        {
            Console.WriteLine(message);
            String Response = Console.ReadLine().ToLower();

            while (Response != "n" && Response != "y")
            {
                Console.WriteLine("What was that?  Would you like to learn more? y/n");
                Response = Console.ReadLine();
            }

            if (Response == "n")
            {
                Console.WriteLine("No problem. Let's go back to the main menu.");
                return false;
            }
            else
                return true;
        }

        //method to delete tasks off the list
        public static void DeleteTask(List<TaskList> taskList, TaskList task)
        {
            taskList.Remove(task);
        }

        //method to mark a task on the list complete
        public static void MarkTaskComplete(List<TaskList> taskList, TaskList task)
        {

            taskList.Remove(task);
        }
    }
}
