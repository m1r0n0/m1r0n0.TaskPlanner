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
            Console.WriteLine("Enter new item by the next pattern " +
                              "(Title, due date, Priority( None, Low, Medium, High, Urgent)): " +
                              "Title dd.MM.yyy Priority");
            var workItem = new WorkItem();
            workItem.Title = Console.ReadLine();
            workItem.DueDate = DateTime.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("fr-FR"));
            workItem.Priority = Enum.Parse<Priority>(Console.ReadLine(), true);

            items.Add(workItem);
        }


        Console.WriteLine("\nTasks:");
        var planner = new SimpleTaskPlanner();
        var tasks = (planner.CreatePlan(items.ToArray()));
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }


    }
}