using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Traversal_Iterator_Composite.Iterators
{
    public abstract class ProjectComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public decimal Cost { get; set; }

        protected ProjectComponent(string name, string description, int duration, decimal cost)
        {
            Name = name;
            Description = description;
            Duration = duration;
            Cost = cost;
        }

        public abstract void Add(ProjectComponent component);
        public abstract void Remove(ProjectComponent component);
        public abstract int GetTotalDuration();
        public abstract decimal GetTotalCost();
    }
}
