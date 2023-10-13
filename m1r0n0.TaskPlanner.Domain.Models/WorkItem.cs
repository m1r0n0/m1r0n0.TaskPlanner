using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using m1r0n0.TaskPlanner.Domain.Models_.Enums;

namespace m1r0n0.TaskPlanner.Domain.Models_
{
    public class WorkItem
    {
        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public Complexity Complexity { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public Guid Id { get; set; }

        public WorkItem(WorkItem item)
        {
            CreationDate = item.CreationDate;
            DueDate = item.CreationDate;
            Priority = item.Priority;
            Complexity = item.Complexity;
            Title = item.Title;
            Description = item.Description;
            IsCompleted = item.IsCompleted;
            Id = item.Id;
        }

        public override string ToString()
        {
            return $"{Title}: due {DueDate:dd.MM.yyy}, {Priority.ToString().ToLower()}";
        }

        public WorkItem Clone(WorkItem item)
        {
            return new WorkItem(item);
        }

    }
}
