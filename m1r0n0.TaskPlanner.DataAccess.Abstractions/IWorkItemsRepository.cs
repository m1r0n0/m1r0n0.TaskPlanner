using m1r0n0.TaskPlanner.Domain.Models_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1r0n0.TaskPlanner.DataAccess.Abstractions
{
    public interface IWorkItemsRepository
    {
        public Guid Add(WorkItem workItem);
        public WorkItem Get(Guid id);
        public WorkItem[] GetAll();
        public bool Update(WorkItem workItem);
        public bool Remove(Guid id);
        public void SaveChanges();

    }
}
