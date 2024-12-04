// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using ToDo_App;

class program
{
    static List<TodoItem> toDoList = new List<TodoItem>();
    static int nextId = 1;
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nTo-Do List:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task as Done");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    AddTask();
                    break;  
                case "2":
                    ViewTask();
                    break;
                case "3":
                    MarkTasksAsDone();
                        break;
                case "4":
                    DeleteTask();
                    break;
                case "5":
                    Console.WriteLine("Good bye!");
                    break;
                    return;
                default:
                    Console.WriteLine("Invalid choice. please try again. ");
                    break;


            }
        }

    }
    static void AddTask()
    {
        Console.Write("Enter a Task: ");
        string task = Console.ReadLine();
        TodoItem newTask = new TodoItem
        {
            Id = nextId++,
            Task = task,
            IsCompleted = false
        };
        toDoList.Add(newTask);
        Console.WriteLine("your desired task has been added successfully");
    }
    static void ViewTask()
    {
        Console.WriteLine("\n=== To-Do List ===");
        if (toDoList.Count == 0)
        {
            Console.WriteLine("No Tasks found");
            return;
        }
        int counter = 1;
        Console.WriteLine("Your Tasks: ");
        foreach (var item in toDoList)
        {
            Console.WriteLine($"{counter}: {item.Task}");
            counter++;
        }
    }
    static void MarkTasksAsDone()
    {
        Console.Write("Enter the ID of the task to mark as done: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var task = toDoList.Find(t => t.Id == id);
        if (task != null)
            {
                task.IsCompleted = true;
                Console.WriteLine("Task  is marked as done");
            }
            else
            {
                Console.WriteLine("The task is not complete");
            }

        }
            else
            {

                Console.WriteLine("Invalid ID.");
            }

    }

    static void DeleteTask()
    {
        Console.WriteLine("Enter the ID of the Task you want to delete: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var Task = toDoList.Find(t => t.Id == id);
            if (Task != null)
            {
                toDoList.Remove(Task);
                Console.WriteLine("The task has been deleted");
            }
            else
            {
                Console.WriteLine("The task wasn't found");
            }
            
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
    }
}


