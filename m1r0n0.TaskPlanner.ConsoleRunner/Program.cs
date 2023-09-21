using m1r0n0.TaskPlanner.Domain.Models_;
using m1r0n0.TaskPlanner.Domain.Models_.Enums;
using System.Globalization;
using m1r0n0.TaskPlanner.Domain.Logic;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter amount of new Tasks");
        var amount = int.Parse(Console.ReadLine());

        var items = new List<WorkItem>();
        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine("Enter new item by the next pattern ");
            var workItem = new WorkItem();

            Console.WriteLine("Title: ");                     
            workItem.Title = Console.ReadLine();

            Console.WriteLine("Due date (dd.MM.yyyy): ");
            workItem.DueDate = DateTime.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("fr-FR"));

            Console.WriteLine("Priority( None, Low, Medium, High, Urgent): ");
            workItem.Priority = Enum.Parse<Priority>(Console.ReadLine(), true);

            Console.WriteLine();

            items.Add(workItem);
        }

        Console.WriteLine("Select method of sorting (1-by name, 2- by due date, 3-by priority)");
        int sort_method = int.Parse(Console.ReadLine());


        Console.WriteLine("\nTasks:");
        var planner = new SimpleTaskPlanner(sort_method);
        var tasks = (planner.CreatePlan(items.ToArray()));
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }


    }
}