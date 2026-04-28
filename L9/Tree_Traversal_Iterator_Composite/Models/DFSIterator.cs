using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree_Traversal_Iterator_Composite.Iterators;

namespace Tree_Traversal_Iterator_Composite.Models
{
    public class DFSIterator : IProjectIterator
    {
        private readonly ProjectTask _root;
        private Stack<ProjectComponent> _stack;
        public ProjectComponent Current { get; private set; }

        public DFSIterator(ProjectTask root)
        {
            _root = root;
            Reset();
        }

        public void Reset()
        {
            _stack = new Stack<ProjectComponent>();
            if (_root != null) _stack.Push(_root);
            Current = null;
        }

        public bool MoveNext()
        {
            if (_stack.Count == 0) return false;

            Current = _stack.Pop();

            if (Current is ProjectTask task)
            {
                for (int i = task.SubTasks.Count - 1; i >= 0; i--)
                {
                    _stack.Push(task.SubTasks[i]);
                }
            }
            return true;
        }
    }
}
