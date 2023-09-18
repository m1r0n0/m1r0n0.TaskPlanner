using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using m1r0n0.TaskPlanner.Domain.Models_;

namespace m1r0n0.TaskPlanner.Domain.Logic
{
    public class SimpleTaskPlanner
    {

        public WorkItem[] CreatePlan(WorkItem[] items)
        {
            var itemsAsList = items.ToList();

            itemsAsList.Sort(CompareWorkItemsByPriority);
            itemsAsList.Sort(CompareWorkItemsByDueDate);
            itemsAsList.Sort(CompareWorkItemsByTitle);

            return itemsAsList.ToArray();
        }

        private static int CompareWorkItemsByPriority(WorkItem firstItem, WorkItem secondItem)
        {
            if (firstItem.Priority > secondItem.Priority) return -1;
            
            return 1;
        }

        private static int CompareWorkItemsByDueDate(WorkItem firstItem, WorkItem secondItem)
        {
            return firstItem.DueDate.CompareTo(secondItem.DueDate);
        }

        private static int CompareWorkItemsByTitle(WorkItem firstItem, WorkItem secondItem)
        {
            return string.Compare(firstItem.Title, secondItem.Title);
        }

    }
}
