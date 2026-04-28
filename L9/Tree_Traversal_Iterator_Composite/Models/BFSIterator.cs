using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree_Traversal_Iterator_Composite.Iterators;

namespace Tree_Traversal_Iterator_Composite.Models
{
    public class BFSIterator : IProjectIterator
    {
        private readonly ProjectTask _root;
        private Queue<ProjectComponent> _queue;
        public ProjectComponent Current { get; private set; }

        public BFSIterator(ProjectTask root)
        {
            _root = root;
            Reset();
        }

        public void Reset()
        {
            _queue = new Queue<ProjectComponent>();
            if (_root != null) _queue.Enqueue(_root);
            Current = null;
        }

        public bool MoveNext()
        {
            if (_queue.Count == 0) return false;

            Current = _queue.Dequeue();

            if (Current is ProjectTask task)
            {
                foreach (var child in task.SubTasks)
                {
                    _queue.Enqueue(child);
                }
            }
            return true;
        }
    }
}
