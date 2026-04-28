using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Traversal_Iterator_Composite.Iterators
{
    public class ProjectTask : ProjectComponent
    {
        public List<ProjectComponent> SubTasks { get; } = new List<ProjectComponent>();

        public ProjectTask(string name, string description, int duration, decimal cost)
            : base(name, description, duration, cost) { }

        public override void Add(ProjectComponent component) => SubTasks.Add(component);

        public override void Remove(ProjectComponent component) => SubTasks.Remove(component);

        public override int GetTotalDuration() => Duration + SubTasks.Sum(t => t.GetTotalDuration());

        public override decimal GetTotalCost() => Cost + SubTasks.Sum(t => t.GetTotalCost());
    }
}
